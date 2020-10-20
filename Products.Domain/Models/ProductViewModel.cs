using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Products.Domain.Models
{
    public class ProductViewModel
    {
        public int Id { get; set; }

        [Required]
        public int SubCategoryKey { get; set; }
        [Required]
        [MaxLength(20)]
        public string ProductCode { get; set; }
        [Required]
        [MaxLength(20)]
        public string ProductName { get; set; }
        [Required]
        [MaxLength(20)]
        public string ProductDescription { get; set; }
        [Required]
        public Decimal ProductNetPrice { get; set; }
        [Required]
        [Column(TypeName = "datetime")]
        public DateTime CreatedDate { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? ModifiedDate { get; set; }
        [Required]
        public int OrganisationId { get; set; }
    }
}
