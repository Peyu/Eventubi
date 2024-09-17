using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Eventubi.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EventsController : ControllerBase
    {

        [HttpGet("")]
        public async Task<IActionResult> Events()
        {
            var test = "this is a test";

            return Ok(test);
        }

    }
}
