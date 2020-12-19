using System.Collections.Generic;

namespace Products.Domain.Dto.Product
{
    public class ProductViewModel
    {
        public int ProductId { get; set; }
        public int ProductSubCategoryBaseId { get; set; }
        public string ProductCode { get; set; }
        public string ProductName { get; set; }
        public string ProductDescription { get; set; }
        public decimal ProductNetPrice { get; set; }
        public decimal ProductGrossPrice { get; set; }
        public int OrganizationBaseId { get; set; }
        public string OrganizationName { get; set; }
        public List<SubCategory> SubCategories { get; set; }
        public List<Organization> Organizations { get; set; }
    }

    public class SubCategory
    {
        public int SubCategoryId { get; set; }
        public string SubCategoryCode { get; set; }
        public string SubCategoryName { get; set; }
    }

    public class Organization
    {
        public int Id { get; set; }
        public string OrganizationName { get; set; }
    }

}
