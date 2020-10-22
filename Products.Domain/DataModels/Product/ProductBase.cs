using Products.Domain.DataModels.Organization;
using System;
using System.ComponentModel.DataAnnotations;

namespace Products.Domain.DataModels.Product
{
    public class ProductBase : EntityModelBase
    {
        [Required]
        public int ProductSubCategoryBaseId { get; set; }
        public virtual ProductSubCategoryBase ProductSubCategoryBase { get; set; }
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
        public int OrganizationBaseId { get; set; }
        public virtual OrganizationBase OrganizationBase { get; set; }
    }
}
