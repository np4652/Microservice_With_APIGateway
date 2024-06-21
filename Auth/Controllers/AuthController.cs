using Auth.AppCode;
using Auth.Model;
using Microsoft.AspNetCore.Mvc;

namespace Auth.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AuthController : ControllerBase
    {
        private readonly TokenManager _jwtTokenService;

        public AuthController(TokenManager jwtTokenService)
        {
            _jwtTokenService = jwtTokenService;
        }

        [HttpGet(nameof(Index))]
        public IActionResult Index()
        {
            return Ok("Authservice is running....");
        }

        [HttpPost(nameof(Login))]
        public IActionResult Login(LoginRequest user)
        {
            var loginResult = _jwtTokenService.GenerateAuthToken(user);

            return loginResult is null ? Unauthorized() : Ok(loginResult);
        }

    }
}
