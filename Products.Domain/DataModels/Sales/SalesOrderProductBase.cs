using Products.Domain.DataModels.Organization;
using System.ComponentModel.DataAnnotations;

namespace Products.Domain.DataModels.Sales
{
    public class SalesOrderProductBase : EntityModelBase
    {

        public int? ProductBaseId { get; set; }
        public int? Quantity { get; set; }
        public int? NetPrice { get; set; }
        public int? SalesOrderProductStatusBaseId { get; set; }
        public virtual SalesOrderProductStatusBase SalesOrderProductStatusBase { get; set; }
        [Required]
        public int OrganizationBaseId { get; set; }
        public virtual OrganizationBase OrganizationBase { get; set; }
    }


}
