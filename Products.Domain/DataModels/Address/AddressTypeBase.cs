using Products.Domain.DataModels.Organization;
using System.ComponentModel.DataAnnotations;

namespace Products.Domain.DataModels.Address
{
    public class AddressTypeBase : EntityModelBase
    {
        [Required]
        [MaxLength(50)]
        public string AddressType { get; set; }
        [Required]
        public int OrganizationBaseId { get; set; }
        public virtual OrganizationBase OrganizationBase { get; set; }
    }
}
