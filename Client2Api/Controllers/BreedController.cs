using Client2.Model;
using Client2.Service;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Client2Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BreedController : ControllerBase
    {
   
            BreedService breedServices = new BreedService();
            [HttpPost]

            public IActionResult AddBreed([FromBody] BreedModel breed)
            {
                breedServices.AddBreed(breed);
                return Ok();
            }

            [HttpPut]
            public IActionResult UpdateBreed([FromBody] BreedModel breed)
            {
                breedServices.UpdateBreed(breed);
                return Ok();
            }

            [HttpDelete]
            public IActionResult DeleteBreed([FromBody] BreedModel breed)
            {
                breedServices.DeleteBreed(breed);
                return Ok();
            }
    }
}
