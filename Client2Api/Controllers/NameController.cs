using Client2.Model;
using Client2.Service;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Xml.Linq;

namespace Client2Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class NameController : ControllerBase
    {
        NameService nameServices = new NameService();
        [HttpPost]

        public IActionResult AddName([FromBody] NameModel name)
        {
            nameServices.AddName(name);
            return Ok("pumasok");
        }

        [HttpPut]
        public IActionResult UpdateName([FromBody] NameModel name)
        {
            nameServices.UpdateName(name);
            return Ok();
        }

        [HttpDelete]
        public IActionResult DeleteName([FromBody] NameModel name)
        {
            nameServices.DeleteName(name);
            return Ok();
        }
    }
}
