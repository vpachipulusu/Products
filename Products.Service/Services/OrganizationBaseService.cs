using Products.Data.Interfaces;
using Products.Domain.DataModels.Organization;
using Products.Service.Services.Base;
using Products.Service.Services.Interfaces;

namespace Products.Service.Services
{
    public class OrganizationBaseService : BaseService<OrganizationBase>, IOrganizationBaseService
    {
        private readonly IOrganizationBaseRepository _organizationBaseRepository;

        public OrganizationBaseService(IOrganizationBaseRepository organizationBaseRepository) : base(organizationBaseRepository)
        {
            _organizationBaseRepository = organizationBaseRepository;
        }
    }
}
