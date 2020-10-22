using System.ComponentModel.DataAnnotations;

namespace Products.Domain.Dto.Address
{
    public class AddressTypeBaseViewModel : EntityViewModelBase
    {
        [Required]
        [MaxLength(50)]
        public string AddressType { get; set; }
        [Required]
        public int OrganizationBaseId { get; set; }
    }
}
