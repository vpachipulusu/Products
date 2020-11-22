using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Products.Api.Base;
using Products.Data.Interfaces;
using Products.Domain.DataModels.Organization;
using Products.Domain.Dto.Organization;
using System;
using System.Threading.Tasks;

namespace Products.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class OrganizationController : CustomBaseController
    {
        protected readonly IOrganizationBaseRepository _organizationBaseRepository;
        private readonly IMapper _mapper;

        public OrganizationController(IOrganizationBaseRepository organizationBaseRepository, IMapper mapper)
        {
            _organizationBaseRepository = organizationBaseRepository;
            _mapper = mapper;
        }

        [HttpGet("{id}")]
        public virtual async Task<IActionResult> Get(int id)
        {
            try
            {
                var entity = await _organizationBaseRepository.Get(id);
                if (entity == null)
                    return new NotFoundResult();

                var model = _mapper.Map<OrganizationBaseViewModel>(entity);
                return new ObjectResult(model);
            }
            catch (Exception e)
            {
                base.LogError<OrganizationController>(e);
                return StatusCode(StatusCodes.Status500InternalServerError);
            }
        }

        [HttpGet]
        public virtual async Task<IActionResult> Get()
        {
            try
            {
                var results = await _organizationBaseRepository.GetAll();
                return new ObjectResult(results);
            }
            catch (Exception e)
            {
                base.LogError<OrganizationController>(e);
                return StatusCode(StatusCodes.Status500InternalServerError);
            }
        }

        [HttpPost]
        public virtual async Task<IActionResult> Post([FromBody] OrganizationBaseViewModel product)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    var entity = _mapper.Map<OrganizationBase>(product);
                    await _organizationBaseRepository.Insert(entity);
                    return Ok();
                }

                return new BadRequestResult();
            }
            catch (Exception e)
            {
                base.LogError<OrganizationController>(e);
                return StatusCode(StatusCodes.Status500InternalServerError);
            }
        }

    }
}
