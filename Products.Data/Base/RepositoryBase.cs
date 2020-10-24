using Dapper;
using Microsoft.Extensions.Options;
using Products.Data.Base.Interfaces;
using Products.Domain.DataModels;
using Products.Domain.Dto;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Products.Data.Base
{
    public abstract class RepositoryBase<T> : IRepository<T> where T : EntityModelBase
    {
        private readonly DbConfig _config;
        protected readonly string TableName;
        protected virtual string BasicSingleEntityQuery => $"SELECT * FROM {TableName} WHERE Id=@id";

        protected RepositoryBase(IOptions<DbConfig> config, string tableName)
        {
            _config = config.Value;
            TableName = tableName;
        }

        protected virtual List<string> GetListOfProperties()
        {
            // TODO: override for better performance - get a collection of properties manually
            return typeof(T).GetProperties().Where(p => !p.GetMethod.IsVirtual).Select(p => p.Name).ToList();
        }

        public virtual async Task<bool> ExistsAsync(int id)
        {
            await using (var connection = await CreateConnectionAsync())
            {
                return await connection.ExecuteScalarAsync<bool>($"SELECT TOP 1 Id FROM {TableName} WITH(NOLOCK) WHERE Id=@Id", new { Id = id });
            }
        }

        public virtual async Task<bool> IsDuplicatedByFieldAsync(Tuple<string, object> field)
        {
            await using (var connection = await CreateConnectionAsync())
            {
                var (key, value) = field;
                return await connection.ExecuteScalarAsync<bool>($"SELECT TOP 1 1 FROM {TableName} WITH(NOLOCK) WHERE {key}=@fieldValue GROUP BY {field.Item1} HAVING COUNT({field.Item1}) > 1", new { fieldValue = value.ToString() });
            }
        }

        public virtual async Task<bool> ExistsByFieldAsync(Tuple<string, object> field)
        {
            await using (var connection = await CreateConnectionAsync())
            {
                var (key, value) = field;
                return await connection.ExecuteScalarAsync<bool>($"SELECT TOP 1 Id FROM {TableName} WITH(NOLOCK) WHERE {key}=@fieldValue", new { fieldValue = value.ToString() });
            }
        }

        public async Task<T> GetByIdAsync(int id)
        {
            await using (var connection = await CreateConnectionAsync())
            {
                return await connection.QuerySingleOrDefaultAsync<T>(BasicSingleEntityQuery, new { id });
            }
        }

        public virtual async Task<T> GetLatestByFieldAsync(string fieldName)
        {
            await using (var connection = await CreateConnectionAsync())
            {
                return await connection.QueryFirstOrDefaultAsync<T>($"SELECT TOP 1 * FROM {TableName} ORDER BY {fieldName} DESC");
            }
        }

        public virtual async Task<IEnumerable<T>> GetAllAsync()
        {
            await using (var connection = await CreateConnectionAsync())
            {
                return await connection.QueryAsync<T>($"SELECT * FROM {TableName} ORDER BY Id DESC");
            }
        }

        public virtual async Task<T> UpsertAsync(T entity)
        {
            if (entity.Id == 0)
                entity.DateCreated = DateTime.Now;
            else
                entity.DateUpdated = DateTime.Now;

            var query = entity.Id == 0 ? GetInsertQuery() : GetUpdateQuery();
            await using (var connection = await CreateConnectionAsync())
            {
                if (entity.Id == 0)
                {
                    var insertedEntity = await connection.QuerySingleOrDefaultAsync<T>(query, entity);
                    entity.Id = insertedEntity.Id;
                    entity.RowVersion = insertedEntity.RowVersion;
                }
                else
                {
                    var r = await connection.ExecuteAsync(query, entity);
                    if (r == 0)
                        throw new DBConcurrencyException($"Update on entity failed.");

                }
            }

            return entity;
        }

        public virtual async Task UpsertAsync(List<T> entities)
        {
            var insert = entities.All(e => e.Id == 0);
            var query = insert ? GetInsertQuery() : GetUpdateQuery();
            await using (var connection = await CreateConnectionAsync())
            {
                var result = await connection.ExecuteAsync(query, entities);
                if (!insert && result == 0)
                {
                    throw new DBConcurrencyException($"In {nameof(UpsertAsync)}, could not update");
                }
            }
        }

        public virtual async Task DeleteAsync(int id)
        {
            await using (var connection = await CreateConnectionAsync())
            {
                await connection.ExecuteAsync($"DELETE FROM {TableName} WHERE Id=@Id", new { Id = id });
            }
        }

        public virtual async Task DeleteAsync(T entity)
        {
            await DeleteAsync(entity.Id);
        }

        public virtual async Task SoftDeleteAsync(int id)
        {
            await using (var connection = await CreateConnectionAsync())
            {
                await connection.ExecuteAsync($"UPDATE {TableName} SET DateDeleted={DateTime.Now} WHERE Id=@Id", new { Id = id });
            }
        }

        public virtual async Task UpdateSpecificColumnsAsync(int id, Dictionary<string, object> columns)
        {
            var sql = string.Join(",", columns.Select(x => $"{x.Key}={x.Value}"));

            await using (var connection = await CreateConnectionAsync())
            {
                await connection.ExecuteAsync($"UPDATE {TableName} SET {sql} WHERE Id=@Id", new { Id = id });
            }
        }

        public virtual async Task<T> GetSpecificColumnsByIdAsync(int id, List<string> columns)
        {
            await using (var connection = await CreateConnectionAsync())
            {
                return (await connection.QueryAsync<T>(
                    $"SELECT {string.Join(",", columns.ToArray())}  FROM {TableName} " +
                    $"WHERE Id = @id",
                    new { id })).FirstOrDefault();
            }
        }

        public virtual async Task SoftDeleteAsync(T entity)
        {
            await SoftDeleteAsync(entity.Id);
        }

        protected async Task<SqlConnection> CreateConnectionAsync()
        {
            var conn = new SqlConnection(_config.DefaultDatabase);
            await conn.OpenAsync();
            return conn;
        }

        private string GetUpdateQuery()
        {
            var updateQuery = new StringBuilder($"UPDATE {TableName} SET ");
            var properties = GetListOfProperties().Except(new List<string>() { $"DateCreated" }).ToList();

            properties.ForEach(property =>
            {
                if (NotIdOrRowVersion(property))
                {
                    updateQuery.Append($"{property}=@{property},");
                }
            });

            updateQuery.Remove(updateQuery.Length - 1, 1);
            updateQuery.Append(" WHERE Id=@Id ");

            return updateQuery.ToString();
        }

        private string GetInsertQuery(bool? includeSelect = true)
        {
            var insertQuery = new StringBuilder($"INSERT INTO {TableName} ");
            insertQuery.Append("(");
            var properties = GetListOfProperties();

            properties.ForEach(property =>
            {
                if (NotIdOrRowVersion(property))
                {
                    insertQuery.Append($"[{property}],");
                }
            });
            insertQuery.Remove(insertQuery.Length - 1, 1).Append(") VALUES (");

            properties.ForEach(property =>
            {
                if (NotIdOrRowVersion(property))
                {
                    insertQuery.Append($"@{property},");
                }
            });
            insertQuery.Remove(insertQuery.Length - 1, 1).Append(")");
            if (includeSelect != null && includeSelect.Value)
                insertQuery.Append("SELECT CAST(SCOPE_IDENTITY() as int) as Id");

            return insertQuery.ToString();
        }

        private bool NotIdOrRowVersion(string property)
        {
            return !property.Equals("Id") && !property.Equals("RowVersion");
        }
    }
}
