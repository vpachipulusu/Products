using Products.Domain.DataModels.Product;
using System.Threading.Tasks;

namespace Products.Service.Services.Interfaces
{
    public interface IProductService
    {
        Task<ProductBase> GetProductById(int id);
        Task AddProduct(ProductBase product);
        Task UpdateProduct(ProductBase product);
        Task DeleteProduct(int id);
    }
}
