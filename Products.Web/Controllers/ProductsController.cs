using Products.Web.Filters;

namespace Products.Web.Controllers
{
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.Extensions.Options;
    using Newtonsoft.Json;
    using Products.Common.HttpProcessor;
    using Products.Domain.Dto.Product;
    using Products.Domain.ViewModels;
    using Products.Web.Models;
    using System.Collections.Generic;
    using System.Net.Http;
    using System.Threading.Tasks;

    public class ProductsController : Controller
    {
        private readonly IOptions<OrganizationSettings> _organizationSettings;

        public ProductsController(IOptions<OrganizationSettings> organizationSettings, IHttpClientFactory httpClientFactory)
        {
            HttpRequestFactory.HttpClientFactory = httpClientFactory;
            _organizationSettings = organizationSettings;
        }

        public async Task<IActionResult> Index()
        {
            ProductsViewModel productsViewModel = new ProductsViewModel();

            var response = await HttpRequestFactory.Get($"{_organizationSettings.Value.WebApiUri}/Product", _organizationSettings.Value.Key);
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

            var response = await HttpRequestFactory.Post($"{_organizationSettings.Value.WebApiUri}/Product", model, _organizationSettings.Value.Key);
            return RedirectToAction("Index", "Products");
        }

        public async Task<IActionResult> EditDetailsInput(int id)
        {
            var getProductResponse = await HttpRequestFactory.Get($"{_organizationSettings.Value.WebApiUri}/Product/{id}", _organizationSettings.Value.Key);
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

            var response = await HttpRequestFactory.Put($"{_organizationSettings.Value.WebApiUri}/Product", model, _organizationSettings.Value.Key);
            return RedirectToAction("Index", "Products");
        }

        public async Task<IActionResult> DeleteProduct(int id)
        {
            var getProductResponse = await HttpRequestFactory.Get($"{_organizationSettings.Value.WebApiUri}/Product/{id}", _organizationSettings.Value.Key);
            var productViewModel = JsonConvert.DeserializeObject<ProductBaseViewModel>(await getProductResponse.Content.ReadAsStringAsync());

            if (productViewModel == null)
            {
                return View("Error");
            }

            var response = await HttpRequestFactory.Delete($"{_organizationSettings.Value.WebApiUri}/Product/{id}", _organizationSettings.Value.Key);
            return RedirectToAction("Index", "Products");
        }
    }
}
