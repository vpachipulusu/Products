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
    }


}
