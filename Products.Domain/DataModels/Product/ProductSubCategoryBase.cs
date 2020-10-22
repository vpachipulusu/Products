using System.ComponentModel.DataAnnotations;

namespace Products.Domain.DataModels.Product
{
    public class ProductSubCategoryBase : EntityModelBase
    {
        [Required]
        [MaxLength(20)]
        public string SubCategoryCode { get; set; }
        [Required]
        public int ProductCategoryId { get; set; }
        [Required]
        public int OrganizationBaseId { get; set; }
    }


}
