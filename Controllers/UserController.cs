using Microsoft.AspNetCore.Mvc;

namespace condominium_backend.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class UserController : ControllerBase
    {
        [HttpGet]
        public IActionResult GetAll() 
        {
            return NotFound("Renzo prof");
        }

        [HttpGet("{id}")]
        public IActionResult GetById(Guid id)
        {
            return NotFound("Renzo prof");
        }

        [HttpPost]
        public IActionResult Insert()
        {
            return NotFound("Renzo prof");
        }

        [HttpPut]
        public IActionResult Update()
        {
            return NotFound("Renzo prof");
        }

        [HttpDelete]
        public IActionResult Delete()
        {
            return NotFound("Renzo prof");
        }
    }
}
