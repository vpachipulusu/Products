using System.ComponentModel.DataAnnotations;

namespace Products.Domain.DataModels.Address
{
    public class AddressTypeBase : EntityModelBase
    {
        [Required]
        [MaxLength(50)]
        public string AddressType { get; set; }
    }
}
