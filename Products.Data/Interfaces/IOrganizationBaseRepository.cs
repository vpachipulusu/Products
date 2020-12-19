using Products.Domain.DataModels.Organization;
using Products.Domain.Dto.Product;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Products.Data.Interfaces
{
    public interface IOrganizationBaseRepository
    {
        Task<IEnumerable<OrganizationBase>> GetAll();

        Task<OrganizationBase> Get(int id);

        Task Insert(OrganizationBase model);

        Task<List<Organization>> GetOrganizations();
    }
}
