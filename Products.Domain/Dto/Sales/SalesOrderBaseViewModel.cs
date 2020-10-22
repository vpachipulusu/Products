using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Products.Domain.Dto.Sales
{
    public class SalesOrderBaseViewModel : EntityViewModelBase
    {
        [Required]
        public int SalesOrderStatusBaseId { get; set; }
        [Required]
        public int CustomerBaseId { get; set; }
        [Required]
        [Column(TypeName = "datetime")]
        public DateTime SalesOrderDate { get; set; }
        [Required] public int OrganizationBaseId { get; set; }
    }
}
