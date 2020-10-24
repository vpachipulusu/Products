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
    }
}
