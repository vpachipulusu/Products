using Products.Data.Base.Interfaces;
using Products.Domain.DataModels.Product;
using Products.Domain.Dto.Product;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Products.Data.Interfaces
{
    public interface IProductBaseRepository : IRepository<ProductBase>
    {
        Task<ProductViewModel> GetProductById(int id);
        Task<List<SubCategory>> GetSubCategories();
    }
}
