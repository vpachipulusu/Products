using Products.Data.Base.Interfaces;
using Products.Domain.DataModels;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Products.Service.Services.Base
{
    public class BaseService<T> : IBaseService<T> where T : EntityModelBase
    {
        protected readonly IRepository<T> _repository;

        public BaseService(IRepository<T> repository)
        {
            _repository = repository;
        }

        public virtual async Task<T> GetByIdAsync(int id)
        {
            return await _repository.GetByIdAsync(id);
        }

        public virtual async Task<IEnumerable<T>> GetAllAsync()
        {
            return await _repository.GetAllAsync();
        }

        public virtual async Task<T> UpsertAsync(T entity)
        {
            return await _repository.UpsertAsync(entity);
        }

        public virtual async Task UpsertAsync(List<T> entities)
        {
            await _repository.UpsertAsync(entities);
        }

        public async Task DeleteAsync(T entity)
        {
            await _repository.DeleteAsync(entity);
        }

        public async Task DeleteAsync(int id)
        {
            await _repository.DeleteAsync(id);
        }

        public async Task SoftDeleteAsync(int id)
        {
            var t = await _repository.GetByIdAsync(id);
            t.DateDeleted = DateTime.Now;
            await UpsertAsync(t);
        }

        public async Task<T> GetSpecificColumnsByIdAsync(int id, List<string> columns)
        {
            return await _repository.GetSpecificColumnsByIdAsync(id, columns);
        }

        public async Task UpdateSpecificColumnsAsync(int id, Dictionary<string, object> columns)
        {
            await _repository.UpdateSpecificColumnsAsync(id, columns);
        }
    }
}
