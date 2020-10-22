﻿using System;
using System.ComponentModel.DataAnnotations;

namespace Products.Domain.DataModels.Product
{
    public class ProductBase : EntityModelBase
    {
        [Required]
        public int ProductSubCategoryBaseId { get; set; }
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
    }
}
