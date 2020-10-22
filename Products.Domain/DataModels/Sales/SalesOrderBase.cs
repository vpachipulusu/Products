using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Products.Domain.DataModels.Sales
{
    public class SalesOrderBase : EntityModelBase
    {
        [Required]
        public int SalesOrderStatusId { get; set; }
        [Required]
        public int CustomerBaseId { get; set; }
        [Required]
        [Column(TypeName = "datetime")]
        public DateTime SalesOrderDate { get; set; }
        [Required]
        public int OrganizationBaseId { get; set; }
    }

}
