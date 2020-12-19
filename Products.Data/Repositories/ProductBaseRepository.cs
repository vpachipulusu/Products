using Dapper;
using Microsoft.Extensions.Options;
using Products.Data.Base;
using Products.Data.Interfaces;
using Products.Domain.DataModels.Product;
using Products.Domain.Dto;
using Products.Domain.Dto.Product;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;

namespace Products.Data.Repositories
{
    public class ProductBaseRepository : RepositoryBase<ProductBase>, IProductBaseRepository
    {
        string _connectionString;
        private IOrganizationBaseRepository _organizationBaseRepository;

        public ProductBaseRepository(IOptions<DbConfig> config, IOrganizationBaseRepository organizationBaseRepository) : base(config, nameof(ProductBase))
        {
            _connectionString = config.Value.DefaultDatabase;
            _organizationBaseRepository = organizationBaseRepository;
        }

        public async Task<ProductViewModel> GetProductById(int id)
        {
            IEnumerable<ProductViewModel> products;

            using (var connection = new SqlConnection(_connectionString))
            {
                await connection.OpenAsync();

                products = await connection.QueryAsync<ProductViewModel>("usp_product_get",
                                                                                  new { Id = id },
                                                                                  commandType: CommandType.StoredProcedure);
            }
            var product = products.FirstOrDefault();
            product.SubCategories = await GetSubCategories();
            product.Organizations = await _organizationBaseRepository.GetOrganizations();

            return product;
        }

        public async Task<List<SubCategory>> GetSubCategories()
        {
            IEnumerable<SubCategory> subCategories;

            using (var connection = new SqlConnection(_connectionString))
            {
                await connection.OpenAsync();

                subCategories = await connection.QueryAsync<SubCategory>("usp_subcategory_select",
                                                                                  commandType: CommandType.StoredProcedure);
            }
            return subCategories.ToList();
        }
    }
}
