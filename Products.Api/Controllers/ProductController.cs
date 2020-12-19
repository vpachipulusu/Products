using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Products.Api.Base;
using Products.Api.Filters;
using Products.Data.Interfaces;
using Products.Domain.DataModels.Product;
using Products.Domain.Dto.Product;
using System;
using System.Threading.Tasks;


namespace Products.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [TypeFilter(typeof(ApiKeyAuthAttribute))]
    public class ProductController : CustomBaseController
    {
        protected readonly IProductBaseRepository ProductService;
        private readonly IMapper _mapper;

        public ProductController(IProductBaseRepository productService, IMapper mapper)
        {
            ProductService = productService;
            _mapper = mapper;
        }

        // GET api/<ProductController>/5
        [HttpGet("{id}")]
        public virtual async Task<IActionResult> Get(int id)
        {
            try
            {
                var entity = await ProductService.GetByIdAsync(id);
                if (entity == null)
                    return new NotFoundResult();

                var model = _mapper.Map<ProductBaseViewModel>(entity);
                return new ObjectResult(model);
            }
            catch (Exception e)
            {
                base.LogError<ProductController>(e);
                return StatusCode(StatusCodes.Status500InternalServerError);
            }
        }

        [HttpGet("[Action]")]
        public virtual async Task<IActionResult> GetProductById(int id)
        {
            try
            {
                var model = await ProductService.GetProductById(id);
                if (model == null)
                    return new NotFoundResult();

                return new ObjectResult(model);
            }
            catch (Exception e)
            {
                base.LogError<ProductController>(e);
                return StatusCode(StatusCodes.Status500InternalServerError);
            }
        }

        // GET api/<ProductController>
        [HttpGet]
        public virtual async Task<IActionResult> Get()
        {
            try
            {
                var results = await ProductService.GetAllAsync();
                return new ObjectResult(results);
            }
            catch (Exception e)
            {
                base.LogError<ProductController>(e);
                return StatusCode(StatusCodes.Status500InternalServerError);
            }
        }

        // POST api/<ProductController>
        [HttpPost]
        public virtual async Task<IActionResult> Post([FromBody] ProductBaseViewModel product)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    var entity = _mapper.Map<ProductBase>(product);
                    return Ok(await ProductService.UpsertAsync(entity));
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
        [HttpPut]
        public virtual async Task<IActionResult> Put([FromBody] ProductBaseViewModel product)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    var entity = await ProductService.GetByIdAsync(product.Id);
                    if (entity == null)
                        return new NotFoundResult();

                    var updatedEntity = _mapper.Map<ProductBase>(product);
                    return Ok(await ProductService.UpsertAsync(updatedEntity));
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
        [HttpDelete("{id}")]
        public virtual async Task<IActionResult> Delete(int id)
        {
            try
            {
                var entity = await ProductService.GetByIdAsync(id);
                if (entity == null)
                    return new NotFoundResult();

                await ProductService.DeleteAsync(id);
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
