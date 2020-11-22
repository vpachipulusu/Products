using Dapper;
using Microsoft.Extensions.Options;
using Products.Data.Interfaces;
using Products.Domain.DataModels.Organization;
using Products.Domain.Dto;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;

namespace Products.Data.Repositories
{
    public class OrganizationBaseRepository : IOrganizationBaseRepository
    {
        string _connectionString;

        public OrganizationBaseRepository(IOptions<DbConfig> config)
        {
            _connectionString = config.Value.DefaultDatabase;
        }

        public async Task<IEnumerable<OrganizationBase>> GetAll()
        {
            IEnumerable<OrganizationBase> organizationBases;

            using (var connection = new SqlConnection(_connectionString))
            {
                await connection.OpenAsync();

                organizationBases = await connection.QueryAsync<OrganizationBase>("usp_organizationbase_select",
                                                                                  commandType: CommandType.StoredProcedure);
            }
            return organizationBases;
        }

        public async Task<OrganizationBase> Get(int id)
        {
            IEnumerable<OrganizationBase> organizationBases;

            using (var connection = new SqlConnection(_connectionString))
            {
                await connection.OpenAsync();

                organizationBases = await connection.QueryAsync<OrganizationBase>("usp_organizationbase_get",
                                                                                  new { Id = id },
                                                                                  commandType: CommandType.StoredProcedure);
            }
            return organizationBases.FirstOrDefault();
        }

        public async Task Insert(OrganizationBase model)
        {
            using (var connection = new SqlConnection(_connectionString))
            {
                await connection.OpenAsync();

                await connection.ExecuteAsync("usp_organizationbase_insert",
                                               new { OrganizationName = model.OrganizationName, Active = model.Active, SystemAdminId = model.SystemAdminId, OAuthKey = model.OAuthKey },
                                               commandType: CommandType.StoredProcedure);
            }
        }

    }
}
