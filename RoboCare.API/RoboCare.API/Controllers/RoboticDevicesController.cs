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

        [Route("/List/{ID:range(1,8)}")]
        public IActionResult IDD(int id)
        {
            var data = MockDataStore.MyData;

            var foundDevice = data.FirstOrDefault(i => i.ID == id);

            return Ok(foundDevice);
        }
    }
}



