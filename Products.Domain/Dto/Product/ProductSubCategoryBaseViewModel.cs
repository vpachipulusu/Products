using System.ComponentModel.DataAnnotations;

namespace Products.Domain.Dto.Product
{
    public class ProductSubCategoryBaseViewModel : EntityViewModelBase

    {
        [Required]
        [MaxLength(20)]
        public string SubCategoryCode { get; set; }
        [Required]
        [MaxLength(60)]
        public string SubCategory { get; set; }
        [Required]
        public int ProductCategoryBaseId { get; set; }
        [Required]
        public int OrganizationBaseId { get; set; }
    }
}
