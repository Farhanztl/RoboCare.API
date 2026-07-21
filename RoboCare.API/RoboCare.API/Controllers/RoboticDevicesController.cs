using Microsoft.AspNetCore.Mvc;
using RoboCare.API.Data;
using RoboCare.API.Models;
using Services;
using ServiceContracts;


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

        [Route("/List/{ID}")]
        public IActionResult FoundDB(int id)
        {
            var data = MockDataStore.MyData;

            var foundDevice = data.FirstOrDefault(i => i.ID == id);

            return Ok(foundDevice);
        }

        [HttpPost("/Add")]
        public IActionResult AddToDB(RoboticDevice devices)
        {
            var data = MockDataStore.MyData;

            data.Add(devices);

            return Ok(" Device Add Successfully! ");

        }

        [HttpDelete("/Delete/{ID}")]
        public IActionResult DeleteDB(int id)
        {
            var data = MockDataStore.MyData;

            var foundDevice = data.FirstOrDefault(i => i.ID == id);

            if (foundDevice == null)
            {
                return NotFound("Device not found!");
            }

            data.Remove(foundDevice);

            return Ok("Device Successfuly Delete");
        }

        [HttpPut("/Update/{ID}")]
        public IActionResult UpdateDB(int id,RoboticDevice devices)
        {
            var data = MockDataStore.MyData;

            var foundDevice = data.FirstOrDefault(i => i.ID == id);

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



