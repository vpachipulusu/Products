using Microsoft.Extensions.Options;
using Products.Data.Base;
using Products.Data.Interfaces;
using Products.Domain.DataModels.Organization;
using Products.Domain.Dto;

namespace Products.Data.Repositories
{
    public class OrganizationBaseRepository : RepositoryBase<OrganizationBase>, IOrganizationBaseRepository
    {
        public OrganizationBaseRepository(IOptions<DbConfig> config) : base(config, nameof(OrganizationBase))
        {
        }
    }
}
