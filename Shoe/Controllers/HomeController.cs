using Microsoft.AspNetCore.Mvc;

namespace Shoe.Controllers
{
    public class HomeController : Controller
    {
        [HttpGet("/")]
        public IActionResult Index() => Ok("Shoe service is running");
    }
}
