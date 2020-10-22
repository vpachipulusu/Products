using Products.Data.Interfaces;
using Products.Domain.DataModels.Product;
using Products.Service.Services.Base;
using Products.Service.Services.Interfaces;

namespace Products.Service.Services
{
    public class ProductService : BaseService<ProductBase>, IProductBaseService
    {
        private readonly IProductBaseRepository _productBaseRepository;

        public ProductService(IProductBaseRepository productBaseRepository) : base(productBaseRepository)
        {
            _productBaseRepository = productBaseRepository;
        }
    }
}
