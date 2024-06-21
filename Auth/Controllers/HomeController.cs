using Microsoft.AspNetCore.Mvc;

namespace Auth.Controllers
{
    public class HomeController : ControllerBase
    {
        [HttpGet("/")]
        public IActionResult Index() => Ok("Auth service running....");
    }
}
