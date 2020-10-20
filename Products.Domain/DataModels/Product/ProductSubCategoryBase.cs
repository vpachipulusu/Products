using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Products.Domain.DataModels.Product
{
    public class ProductSubCategoryBase
    {
        [Key]
        public int SubCategoryKey { get; set; }
        [Required]
        [MaxLength(20)]
        public string SubCategoryCode { get; set; }
        [Required]
        public int CategoryKey { get; set; }
        [Required]
        [Column(TypeName = "datetime")]
        public DateTime CreatedDate { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? ModifiedDate { get; set; }
        [Required]
        public int OrganisationKey { get; set; }
    }


}
