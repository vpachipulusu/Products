using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Products.Data.Base.Interfaces
{
    public interface IRepository<T>
    {
        Task<T> GetByIdAsync(int id);
        Task<IEnumerable<T>> GetAllAsync();
        Task<T> GetLatestByFieldAsync(string fieldName);
        Task<bool> ExistsAsync(int id);
        Task<bool> IsDuplicatedByFieldAsync(Tuple<string, object> field);
        Task<bool> ExistsByFieldAsync(Tuple<string, object> field);
        Task<T> UpsertAsync(T entity);
        Task UpsertAsync(List<T> entities);
        Task DeleteAsync(T entity);
        Task DeleteAsync(int id);
        Task SoftDeleteAsync(T entity);
        Task SoftDeleteAsync(int id);
        Task<T> GetSpecificColumnsByIdAsync(int id, List<string> columns);
        Task UpdateSpecificColumnsAsync(int id, Dictionary<string, object> columns);
    }
}
