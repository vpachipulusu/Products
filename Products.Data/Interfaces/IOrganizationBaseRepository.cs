using Products.Domain.DataModels.Organization;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Products.Data.Interfaces
{
    public interface IOrganizationBaseRepository
    {
        Task<IEnumerable<OrganizationBase>> GetAll();

        Task<OrganizationBase> Get(int id);

        Task Insert(OrganizationBase model);
    }
}
