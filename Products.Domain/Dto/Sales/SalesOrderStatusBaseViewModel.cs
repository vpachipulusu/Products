using System.ComponentModel.DataAnnotations;

namespace Products.Domain.Dto.Sales
{
    public class SalesOrderStatusBaseViewModel : EntityViewModelBase
    {
        [Required]
        [MaxLength(150)]
        public string SalesOrderStatus { get; set; }
        [Required]
        public int SalesOrderStatusSequence { get; set; }
        [Required]
        public int OrganizationBaseId { get; set; }
    }
}
