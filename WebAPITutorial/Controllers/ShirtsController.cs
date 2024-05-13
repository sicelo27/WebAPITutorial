using Microsoft.AspNetCore.Mvc;
using WebAPITutorial.Models;
using WebAPITutorial.Models.Repositories;

namespace WebAPITutorial.Controllers
{

    [ApiController]
    [Route("api/[controller]")]
    public class ShirtsController : ControllerBase
    {
        [HttpGet]
        public string GetShirts()
        {
            return "Reading all shirts";
        }

        [HttpGet("{id}")]
        public IActionResult GetShirtById(int id)
        {
            if (id < 0)
                return BadRequest();

            var shirt = ShirtRepository.GetShirtById(id);
            if (shirt == null)
                return NotFound();

            return Ok(shirt);
        }

        [HttpPost]
        public string CreateShirt([FromBody] Shirt shirt)
        {
            return "Creating a shirt"; 
        }

        [HttpPut("{id}")]
        public string UpdateShirt(int id)
        {
            return $"Updating shirt: {id}";
        }

        [HttpDelete("{id}")]
        public string DeleteShirt(int id)
        {
            return $"Deleting shirt: {id}";
        }
    }
}
