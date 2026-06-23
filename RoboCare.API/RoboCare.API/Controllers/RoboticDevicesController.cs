using Microsoft.AspNetCore.Mvc;
using RoboCare.API.Data;
using RoboCare.API.Models;

namespace RoboCare.API.Controllers
{

    [ApiController]
    public class RoboticDevicesController : ControllerBase
    {
        [Route("/List")]
        public IActionResult Index()
        {
             return Ok(MockDataStore.MyData);
        }
    }
}
