using Microsoft.AspNetCore.Mvc;
using RoboCare.ServiceContracts.Models;
using Services;
using ServiceContracts;


namespace RoboCare.API.Controllers
{

    [ApiController]
    public class RoboticDevicesController : ControllerBase
    {
        private readonly IRoboticDeviceService _roboticDeviceService;


        public RoboticDevicesController(IRoboticDeviceService roboticDeviceService)
        {
            _roboticDeviceService = roboticDeviceService;
        }

        [Route("/List")]
        public IActionResult Index()
        {
            List<RoboticDevice> Robots = _roboticDeviceService.GetRobots();
            return Ok(Robots);
        }

        [Route("/List/{ID}")]
        public IActionResult FoundDB(int id)
        {
           var Robots = _roboticDeviceService.GetRobots();

            var foundDevice = Robots.FirstOrDefault(i => i.ID == id);

            return Ok(foundDevice);
        }

        [HttpPost("/Add")]
        public IActionResult AddToDB(RoboticDevice devices)
        {
            var Robots = _roboticDeviceService.GetRobots();

            Robots.Add(devices);

            return Ok("Device Add Successfully!");
        }

        [HttpDelete("/Delete/{ID}")]
        public IActionResult DeleteDB(int id)
        {
            var Robots = _roboticDeviceService.GetRobots();

            var foundDevice = Robots.FirstOrDefault(i => i.ID == id);

            if (foundDevice == null)
            {
                return NotFound("Device not found!");
            }

            Robots.Remove(foundDevice);

            return Ok("Device Successfuly Delete");
        }

        [HttpPut("/Update/{ID}")]
        public IActionResult UpdateDB(int id,RoboticDevice devices)
        {
            var Robots = _roboticDeviceService.GetRobots();

            var foundDevice = Robots.FirstOrDefault(i => i.ID == id);

            if (foundDevice == null)
            {
                return NotFound("Device not found!");
            }
            else
            { 
                foundDevice.Model = devices.Model;
                foundDevice.SerialNumber = devices.SerialNumber;
                foundDevice.LastCalibrationDate = devices.LastCalibrationDate;
                foundDevice.IsActive = devices.IsActive;

                return Ok(" Device Update Successfuly! ");
            }
        }
    }
}



