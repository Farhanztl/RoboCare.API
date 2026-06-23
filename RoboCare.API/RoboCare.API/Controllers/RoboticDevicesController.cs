using Microsoft.AspNetCore.Mvc;
using RoboCare.API.Data;
using RoboCare.API.Models;
using System.Security.Cryptography.X509Certificates;

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
        public IActionResult IDDD()
        {
            var data = MockDataStore.MyData;
            string select = Convert.ToString(Request.RouteValues["ID"]);

            var ID1 = data.Where(id => id.ID == 1);
            var ID2 = data.Where(id => id.ID == 2);
            var ID3 = data.Where(id => id.ID == 3);
            var ID4 = data.Where(id => id.ID == 4);
            var ID5 = data.Where(id => id.ID == 5);
            var ID6 = data.Where(id => id.ID == 6);
            var ID7 = data.Where(id => id.ID == 7);
            var ID8 = data.Where(id => id.ID == 8);

            if (select == "1")
            {
                return Ok(ID1);
            }
            else if (select == "2")
            {
                return Ok(ID2);
            }
            else if (select == "3")
            {
                return Ok(ID3);
            }
            else if (select == "4")
            {
                return Ok(ID4);
            }
            else if (select == "5")
            {
                return Ok(ID5);
            }
            else if (select == "6")
            {
                return Ok(ID6);
            }
            else if (select == "7")
            {
                return Ok(ID7);
            }
            else if (select == "8")
            {
                return Ok(ID8);
            }

            return Content("Go Back!");
        }
    }
}



