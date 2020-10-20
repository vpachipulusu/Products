using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Products.Domain.DataModels.Product
{
    public class ProductCategoryBase
    {
        [Key]
        public int CategoryKey { get; set; }
        [Required]
        [MaxLength(20)]
        public string CategoryCode { get; set; }
        [Required]
        [MaxLength(100)]
        public string Category { get; set; }
        [Required]
        [Column(TypeName = "datetime")]
        public DateTime CreatedDate { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? ModifiedDate { get; set; }
        [Required]
        public int OrganisationKey { get; set; }
    }
}
