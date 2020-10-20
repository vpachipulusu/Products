using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Products.Api.Base;
using Products.Data.Interfaces;
using Products.Domain.DataModels.Product;
using Products.Domain.Models;
using Products.Service.Helpers;
using System;


namespace Products.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : CustomBaseController
    {
        protected readonly IProductBaseRepository ProductService;

        public ProductController(IProductBaseRepository productService)
        {
            ProductService = productService;
        }

        // GET api/<ProductController>/5
        [Authorize]
        [HttpGet("{id}")]
        public virtual IActionResult Get(int id)
        {
            try
            {
                var entity = ProductService.GetByIdAsync(id).GetAwaiter().GetResult();
                if (entity == null)
                    return new NotFoundResult();

                var model = new ProductViewModel()
                {
                    Id = entity.Id,
                    ProductName = entity.ProductName,
                    ProductDescription = entity.ProductDescription
                };

                return new ObjectResult(model);
            }
            catch (Exception e)
            {
                base.LogError<ProductController>(e);
                return StatusCode(StatusCodes.Status500InternalServerError);
            }
        }

        // GET api/<ProductController>
        [Authorize]
        [HttpGet]
        public string Get()
        {
            return "value";
        }

        // POST api/<ProductController>
        [HttpPost]
        public virtual IActionResult Post([FromBody] ProductViewModel product)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    var entity = new ProductBase()
                    {
                        ProductName = product.ProductName,
                        ProductDescription = product.ProductDescription,
                        SubCategoryKey = 1,
                        ProductCode = "code",
                        ProductNetPrice = 100,
                        CreatedDate = DateTime.Now,
                        OrganisationId = 1
                    };

                    ProductService.UpsertAsync(entity);
                    return Ok();
                }

                return new BadRequestResult();
            }
            catch (Exception e)
            {
                base.LogError<ProductController>(e);
                return StatusCode(StatusCodes.Status500InternalServerError);
            }
        }

        // PUT api/<ProductController>/5
        [Authorize]
        [HttpPut("{id}")]
        public virtual IActionResult Put(int id, [FromBody] ProductViewModel product)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    var entity = ProductService.GetByIdAsync(id).GetAwaiter().GetResult();
                    if (entity == null)
                        return new NotFoundResult();

                    entity.ProductName = product.ProductName;
                    entity.ProductDescription = product.ProductDescription;

                    ProductService.UpsertAsync(entity);
                    return Ok();
                }

                return new BadRequestResult();
            }
            catch (Exception e)
            {
                base.LogError<ProductController>(e);
                return StatusCode(StatusCodes.Status500InternalServerError);
            }
        }

        // DELETE api/<ProductController>/5
        [Authorize]
        [HttpDelete("{id}")]
        public virtual IActionResult Delete(int id)
        {
            try
            {
                var entity = ProductService.GetByIdAsync(id).GetAwaiter().GetResult();
                if (entity == null)
                    return new NotFoundResult();

                ProductService.DeleteAsync(id);

                return Ok();
            }
            catch (Exception e)
            {
                base.LogError<ProductController>(e);
                return StatusCode(StatusCodes.Status500InternalServerError);
            }
        }
    }
}
