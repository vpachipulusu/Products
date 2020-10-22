using System.ComponentModel.DataAnnotations;

namespace Products.Domain.Dto.Product
{
    public class ProductCategoryBaseViewModel : EntityViewModelBase
    {
        [Required]
        [MaxLength(20)]
        public string CategoryCode { get; set; }
        [Required]
        [MaxLength(100)]
        public string Category { get; set; }
        [Required]
        public int OrganizationBaseId { get; set; }
    }
}
