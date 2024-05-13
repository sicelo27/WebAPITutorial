using Microsoft.AspNetCore.Mvc;
using WebAPITutorial.Models;

namespace WebAPITutorial.Controllers
{

    [ApiController]
    [Route("api/[controller]")]
    public class ShirtsController : ControllerBase
    {
        private List<Shirt> shirts = new List<Shirt>()
        {
            new Shirt {ShirtId = 1, Brand = "My Brand", Color = "Blue", Gender = "Men", Price = 30, Size = 10},
            new Shirt {ShirtId = 2, Brand = "My Brand", Color = "Black", Gender = "Men", Price = 24, Size = 8},
            new Shirt {ShirtId = 3, Brand = "Your Brand", Color = "Green", Gender = "Women", Price = 32, Size = 6},
            new Shirt {ShirtId = 4, Brand = "Her Brand", Color = "Pink", Gender = "Women", Price = 10, Size = 10},



        };
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

            var shirt = shirts.FirstOrDefault(x =>  x.ShirtId == id);
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
