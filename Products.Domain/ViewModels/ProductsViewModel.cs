using Products.Domain.Dto.Product;
using System.Collections.Generic;

namespace Products.Domain.ViewModels
{
    public class ProductsViewModel
    {
        public ProductsViewModel()
        {
            this.Products = new List<ProductBaseViewModel>();
        }

        public IEnumerable<ProductBaseViewModel> Products { get; set; }

        public int CurrentCategoryId { get; set; }

        public int PagesCount { get; set; }

        public int CurrentPage { get; set; }

        public string SearchType { get; set; }

        public string SearchString { get; set; }

        public int NextPage
        {
            get
            {
                if (this.CurrentPage >= this.PagesCount)
                {
                    return 1;
                }

                return this.CurrentPage + 1;
            }
        }

        public int PreviousPage
        {
            get
            {
                if (this.CurrentPage <= 1)
                {
                    return this.PagesCount;
                }

                return this.CurrentPage - 1;
            }
        }
    }
}
