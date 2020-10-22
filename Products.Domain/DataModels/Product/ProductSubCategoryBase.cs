using Products.Domain.DataModels.Organization;
using System.ComponentModel.DataAnnotations;

namespace Products.Domain.DataModels.Product
{
    public class ProductSubCategoryBase : EntityModelBase
    {
        [Required]
        [MaxLength(20)]
        public string SubCategoryCode { get; set; }
        [Required]
        [MaxLength(60)]
        public string SubCategory { get; set; }
        [Required]
        public int ProductCategoryBaseId { get; set; }
        public virtual ProductCategoryBase ProductCategoryBase { get; set; }
        [Required]
        public int OrganizationBaseId { get; set; }
        public virtual OrganizationBase OrganizationBase { get; set; }
    }


}
