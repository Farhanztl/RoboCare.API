using Microsoft.AspNetCore.Mvc;

namespace RoboCare.API.Controllers
{
    public class RoboticDevicesController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
