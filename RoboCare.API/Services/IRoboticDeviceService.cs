using RoboCare.ServiceContracts.Models;


namespace ServiceContracts
{
    public interface IRoboticDeviceService
    {
        List<RoboticDevice> GetRobots();

        RoboticDevice GetRobotById(int id); //Peida Kardane Yek Robot

        void AddRobot(RoboticDevice device); // Ezafe Kardan

        bool DeleteRobot(int id); // Pak Kardan

        bool UpdateRobot(int id, RoboticDevice updatedDevice); //Update Kardan
    }
}
