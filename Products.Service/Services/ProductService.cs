using Products.Data.Base.Interfaces;
using Products.Domain.DataModels.Product;
using Products.Service.Services.Interfaces;
using System;
using System.Threading.Tasks;

namespace Products.Service.Services
{
    public class ProductService : IProductService
    {
        private readonly IRepository<ProductBase> _productRepository;

        public ProductService(IRepository<ProductBase> productRepository)
        {
            _productRepository = productRepository;
        }

        public async Task<ProductBase> GetProductById(int id)
        {
            if (id == 0)
                throw new ArgumentNullException(nameof(id));

            return await _productRepository.GetByIdAsync(id);
        }

        public async Task AddProduct(ProductBase product)
        {
            if (product == null)
                throw new ArgumentNullException(nameof(ProductBase));

            await _productRepository.UpsertAsync(product);
        }

        public async Task UpdateProduct(ProductBase product)
        {
            if (product == null)
                throw new ArgumentNullException(nameof(ProductBase));

            await _productRepository.UpsertAsync(product);
        }

        public async Task DeleteProduct(int id)
        {
            if (id == 0)
                throw new ArgumentNullException(nameof(id));

            var post = await _productRepository.GetByIdAsync(id);
            if (post == null)
                throw new Exception($"not found post id:{id}");

            await _productRepository.DeleteAsync(post);
        }
    }
}
