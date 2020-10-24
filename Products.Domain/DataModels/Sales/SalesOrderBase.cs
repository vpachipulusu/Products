using Products.Domain.DataModels.Customer;
using Products.Domain.DataModels.Organization;
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Products.Domain.DataModels.Sales
{
    public class SalesOrderBase : EntityModelBase
    {
        public int? SalesOrderStatusBaseId { get; set; }
        public virtual SalesOrderStatusBase SalesOrderStatusBase { get; set; }
        public int? CustomerBaseId { get; set; }
        public virtual CustomerBase CustomerBase { get; set; }
        [Required]
        [Column(TypeName = "datetime")]
        public DateTime SalesOrderDate { get; set; }
        [Required]
        public int OrganizationBaseId { get; set; }
        public virtual OrganizationBase OrganizationBase { get; set; }
    }

}
