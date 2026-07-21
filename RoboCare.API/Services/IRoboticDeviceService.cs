using RoboCare.ServiceContracts.Models;

namespace ServiceContracts
{
    public interface IRoboticDeviceService
    {
        List<RoboticDevice> GetRobots();
    }
}
