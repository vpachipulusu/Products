using Microsoft.Extensions.Options;
using Products.Data.Base;
using Products.Data.Interfaces;
using Products.Domain.DataModels.Product;
using Products.Domain.Models;

namespace Products.Data.Repositories
{
    public class ProductBaseRepository : RepositoryBase<ProductBase>, IProductBaseRepository
    {
        public ProductBaseRepository(IOptions<DbConfig> config) : base(config, nameof(ProductBase))
        {
        }
    }
}
