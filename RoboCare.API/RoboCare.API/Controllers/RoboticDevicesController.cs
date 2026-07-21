using Microsoft.AspNetCore.Mvc;
using RoboCare.ServiceContracts.Models;
using Services;
using ServiceContracts;


namespace RoboCare.API.Controllers
{

    [ApiController]
    public class RoboticDevicesController : ControllerBase
    {
        private readonly IRoboticDeviceService _service;

            
        public RoboticDevicesController(IRoboticDeviceService service)
        {
            _service = service;
        }

        [Route("/List")]
        public IActionResult Index()
        {
            return Ok(_service.GetRobots());
        }

        [Route("/List/{ID}")]
        public IActionResult FoundDB(int id)
        {
            var device = _service.GetRobotById(id);

            if (device == null)
            {
                return NotFound("Device not found!");
            }

            return Ok(device);
        }

        [HttpPost("/Add")]
        public IActionResult AddToDB(RoboticDevice device)
        {
            _service.AddRobot(device);
            return Ok("Device Added Successfully!");
        }

        [HttpDelete("/Delete/{ID}")]
        public IActionResult DeleteDB(int id)
        {
            //Be service migim pakesh kon. Agar false bargardoone yani roboti naboode
            bool isDeleted = _service.DeleteRobot(id);

            if (!isDeleted) return NotFound("Device not found!");

            return Ok("Device Successfully Deleted");
        }

        [HttpPut("/Update/{ID}")]
        public IActionResult UpdateDB(int id,RoboticDevice device)
        {
            // Be Service migim Updatesh kon
            bool isUpdated = _service.UpdateRobot(id, device);

            if (!isUpdated) return NotFound("Device not found!");

            return Ok("Device Updated Successfully!");
        }
    }
}



