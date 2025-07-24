using Microsoft.AspNetCore.Mvc;
using VagasTracker.Model;

namespace VagasTracker.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class VagasTrackerController : ControllerBase
    {
        private static readonly string[] Summaries = new[]
        {
            "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
        };

        private readonly ILogger<VagasTrackerController> _logger;

        public VagasTrackerController(ILogger<VagasTrackerController> logger)
        {
            _logger = logger;
        }

        [HttpGet(Name = "GetVagas")]
        public IActionResult GetVagas() {
            return Ok();
        }

        [HttpPost(Name = "PostVagas")]
        public IActionResult PostVagas()
        {
            return Ok();
        }

        [HttpPut (Name ="PutVagas")]
        public IActionResult PutVagas()
        {
            return Ok();
        }

        [HttpDelete (Name = "DeleteVagas")]

        public IActionResult DeleteVagas()
        {
            return Ok();
        }

    }
}
