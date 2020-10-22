using System.ComponentModel.DataAnnotations;

namespace Products.Domain.DataModels.Sales
{
    public class SalesOrderStatusBase : EntityModelBase
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
