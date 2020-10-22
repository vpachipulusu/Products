using System.ComponentModel.DataAnnotations;

namespace Products.Domain.Dto.Sales
{
    public class SalesOrderProductStatusBaseViewModel : EntityViewModelBase
    {
        [Required]
        [MaxLength(150)]
        public string SalesOrderProductStatus { get; set; }
        [Required]
        public int SalesProductStatusSequence { get; set; }
        [Required]
        public int OrganizationBaseId { get; set; }
    }
}
