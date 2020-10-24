using Products.Domain.DataModels.Organization;
using System.ComponentModel.DataAnnotations;

namespace Products.Domain.DataModels.Product
{
    public class ProductCategoryLink : EntityModelBase
    {
        public int? ProductCategoryBaseId { get; set; }
        public virtual ProductCategoryBase ProductCategoryBase { get; set; }

        public int? ProductSubCategoryBaseId { get; set; }
        public virtual ProductSubCategoryBase ProductSubCategoryBase { get; set; }

        [Required]
        public int OrganizationBaseId { get; set; }
        public virtual OrganizationBase OrganizationBase { get; set; }
    }
}
