using System.Collections.Generic;
using System.Threading.Tasks;

namespace Products.Service.Services.Base
{
    public interface IBaseService<T>
    {
        Task<T> GetByIdAsync(int id);
        Task<IEnumerable<T>> GetAllAsync();
        Task<T> UpsertAsync(T entity);
        Task UpsertAsync(List<T> entities);
        Task DeleteAsync(T entity);
        Task DeleteAsync(int id);
        Task SoftDeleteAsync(int id);
        Task<T> GetSpecificColumnsByIdAsync(int id, List<string> columns);
        Task UpdateSpecificColumnsAsync(int id, Dictionary<string, object> columns);
    }
}
