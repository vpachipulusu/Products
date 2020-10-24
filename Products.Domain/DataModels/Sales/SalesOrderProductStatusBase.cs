using System.ComponentModel.DataAnnotations;

namespace Products.Domain.DataModels.Sales
{
    public class SalesOrderProductStatusBase : EntityModelBase
    {
        [Required]
        [MaxLength(150)]
        public string SalesOrderProductStatus { get; set; }
        [Required]
        public int SalesProductStatusSequence { get; set; }
    }

}
