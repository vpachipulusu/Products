using Products.Web.Filters;

namespace Products.Web.Controllers
{
    using Microsoft.AspNetCore.Mvc;
    using Newtonsoft.Json;
    using Products.Common.HttpProcessor;
    using Products.Domain.Dto.Product;
    using Products.Domain.ViewModels;
    using System.Collections.Generic;
    using System.Net.Http;
    using System.Threading.Tasks;

    public class ProductsController : Controller
    {
        public ProductsController(IHttpClientFactory httpClientFactory)
        {
            HttpRequestFactory.HttpClientFactory = httpClientFactory;
        }

        public async Task<IActionResult> Index()
        {
            ProductsViewModel productsViewModel = new ProductsViewModel();

            var response = await HttpRequestFactory.Get("http://reddyvelagala-001-site1.dtempurl.com/api/Product", "0xDC331C344414C71865960FB46413F1C1803565A2E8021AEC52A73B0688903FBB");
            productsViewModel.Products = JsonConvert.DeserializeObject<List<ProductBaseViewModel>>(await response.Content.ReadAsStringAsync());
            return View(productsViewModel);
        }

        public IActionResult DetailsInput()
        {
            return this.View();
        }

        [HttpPost]
        [ModelStateValidationActionFilter]
        public async Task<IActionResult> DetailsInput(ProductBaseViewModel model)
        {
            if (model.Id > 0 || model.Id < 0)
            {
                return View("Error");
            }

            var response = await HttpRequestFactory.Post("http://reddyvelagala-001-site1.dtempurl.com/api/Product", model, "0xDC331C344414C71865960FB46413F1C1803565A2E8021AEC52A73B0688903FBB");
            return RedirectToAction("Index", "Products");
        }

        public async Task<IActionResult> EditDetailsInput(int id)
        {
            var getProductResponse = await HttpRequestFactory.Get($"http://reddyvelagala-001-site1.dtempurl.com/api/Product/{id}", "0xDC331C344414C71865960FB46413F1C1803565A2E8021AEC52A73B0688903FBB");
            var productViewModel = JsonConvert.DeserializeObject<ProductBaseViewModel>(await getProductResponse.Content.ReadAsStringAsync());
            return this.View(productViewModel);
        }

        [HttpPost]
        [ModelStateValidationActionFilter]
        public async Task<IActionResult> EditDetailsInput(ProductBaseViewModel model)
        {
            if (model.Id <= 0)
            {
                return View("Error");
            }

            var response = await HttpRequestFactory.Put("http://reddyvelagala-001-site1.dtempurl.com/api/Product", model, "0xDC331C344414C71865960FB46413F1C1803565A2E8021AEC52A73B0688903FBB");
            return RedirectToAction("Index", "Products");
        }

        public async Task<IActionResult> DeleteProduct(int id)
        {
            var getProductResponse = await HttpRequestFactory.Get($"http://reddyvelagala-001-site1.dtempurl.com/api/Product/{id}", "0xDC331C344414C71865960FB46413F1C1803565A2E8021AEC52A73B0688903FBB");
            var productViewModel = JsonConvert.DeserializeObject<ProductBaseViewModel>(await getProductResponse.Content.ReadAsStringAsync());

            if (productViewModel == null)
            {
                return View("Error");
            }

            var response = await HttpRequestFactory.Delete($"http://reddyvelagala-001-site1.dtempurl.com/api/Product/{id}", "0xDC331C344414C71865960FB46413F1C1803565A2E8021AEC52A73B0688903FBB");
            return RedirectToAction("Index", "Products");
        }
    }
}
