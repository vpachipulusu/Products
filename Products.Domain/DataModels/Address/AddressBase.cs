using System.ComponentModel.DataAnnotations;

namespace Products.Domain.DataModels.Address
{
    public class AddressBase : EntityModelBase
    {
        [Required]
        public int AddressTypeId { get; set; }
        public int? EntityBaseId { get; set; }
        [MaxLength(120)]
        public string AddressL1 { get; set; }
        [Required]
        [MaxLength(120)]
        public string AddressL2 { get; set; }
        [MaxLength(120)]
        public string AddressL3 { get; set; }
        [MaxLength(120)]
        public string AddressL4 { get; set; }
        [MaxLength(120)]
        public string AddressL5 { get; set; }
        [MaxLength(80)]
        public string AddressL6 { get; set; }
        [MaxLength(80)]
        public string AddressL7 { get; set; }
        [Required]
        public int AddressStatus { get; set; }
        [Required]
        public int OrganizationBaseId { get; set; }
    }


}
