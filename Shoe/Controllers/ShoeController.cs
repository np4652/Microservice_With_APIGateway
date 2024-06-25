using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Shoe.Application;
using System.Security.Claims;

namespace Shoe.Controllers
{
    [Authorize]
    [Route("api/[controller]")]
    [ApiController]
    public class ShoesController : ControllerBase
    {
        private readonly IShoeRepository _shoeRepository;

        public ShoesController(IShoeRepository shoeRepository)
        {
            _shoeRepository = shoeRepository;
        }

        [HttpGet]
        public IActionResult Get()
        {
            var userName = User.FindFirstValue("username");
            return Ok(_shoeRepository.GetShoes());
        }

        [HttpDelete("{id:int}")]
        public IActionResult Delete(int id)
        {
            var shoeDeleted = _shoeRepository.DeleteShoe(id);
            return shoeDeleted ? NoContent() : NotFound();
        }
    }
}
