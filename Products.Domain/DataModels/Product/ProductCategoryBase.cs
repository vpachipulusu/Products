using Products.Domain.DataModels.Organization;
using System.ComponentModel.DataAnnotations;

namespace Products.Domain.DataModels.Product
{
    public class ProductCategoryBase : EntityModelBase
    {
        [Required]
        [MaxLength(20)]
        public string CategoryCode { get; set; }
        [Required]
        [MaxLength(100)]
        public string Category { get; set; }
        [Required]
        public int OrganizationBaseId { get; set; }
        public virtual OrganizationBase OrganizationBase { get; set; }
    }
}
