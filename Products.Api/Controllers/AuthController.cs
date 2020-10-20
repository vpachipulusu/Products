using Microsoft.AspNetCore.Mvc;
using Products.Domain.Authentication;
using Products.Service.Services.Interfaces;

namespace Products.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AuthController : ControllerBase
    {
        private readonly ICustomAuthenticationService _customAuthentication;

        public AuthController(ICustomAuthenticationService customAuthentication)
        {
            _customAuthentication = customAuthentication;
        }

        [HttpPost("authenticate")]
        public IActionResult Authenticate(AuthenticateRequest model)
        {
            var response = _customAuthentication.Authenticate(model);

            if (response == null)
                return BadRequest(new { message = "Username or password is incorrect" });

            return Ok(response);
        }
    }
}
