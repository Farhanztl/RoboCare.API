using RoboCare.ServiceContracts.Models;
using ServiceContracts;

namespace Services
{
    public class RoboticDeviceService : IRoboticDeviceService
    {


        private List<RoboticDevice> _RoboticDevice;

        public RoboticDeviceService()
        {
            _RoboticDevice = new List<RoboticDevice>()
            {
                new RoboticDevice() {ID = 1,Model = "SIM",SerialNumber = "A1000",LastCalibrationDate = new DateTime(2021,02,12), IsActive = true},
                new RoboticDevice() {ID = 2,Model = "Flex",SerialNumber = "B1000",LastCalibrationDate = new DateTime(2015,10,19), IsActive = false},
                new RoboticDevice() {ID = 3,Model = "SIM",SerialNumber = "A1001",LastCalibrationDate = new DateTime(2001,12,23), IsActive = false},
                new RoboticDevice() {ID = 4,Model = "Flex",SerialNumber = "B1001",LastCalibrationDate = new DateTime(2022,01,21), IsActive = true},
                new RoboticDevice() {ID = 6,Model = "Flex",SerialNumber = "B1003",LastCalibrationDate = new DateTime(2019,05,10), IsActive = true},
                new RoboticDevice() {ID = 5,Model = "Robo",SerialNumber = "C1000",LastCalibrationDate = new DateTime(2025,12,12), IsActive = true},
                new RoboticDevice() {ID = 7,Model = "Flex",SerialNumber = "B1004",LastCalibrationDate = new DateTime(2008,08,16), IsActive = false},
                new RoboticDevice() {ID = 8,Model = "SIM",SerialNumber = "A1002",LastCalibrationDate = new DateTime(2020,11,11), IsActive = true}

            };
        }

        public void AddRobot(RoboticDevice device)
        {
            _RoboticDevice.Add(device);
        }

        public bool DeleteRobot(int id)
        {
            var foundDevice = GetRobotById(id); // aval peidash mikone
            if (foundDevice == null) return false; // age nabood mige nmitnm

            _RoboticDevice.Remove(foundDevice); // age bood pakesh mikone
            return true; // mige ba movafaghiat pak shod
        }

        public RoboticDevice GetRobotById(int id)
        {
            return _RoboticDevice.FirstOrDefault(i => i.ID == id);
        }

        public List<RoboticDevice> GetRobots()
        {
            return _RoboticDevice;
        }

        public bool UpdateRobot(int id, RoboticDevice updatedDevice)
        {
            var foundDevice = GetRobotById(id);
            if (foundDevice == null) return false;

            foundDevice.Model = updatedDevice.Model;
            foundDevice.SerialNumber = updatedDevice.SerialNumber;
            foundDevice.LastCalibrationDate = updatedDevice.LastCalibrationDate;
            foundDevice.IsActive = updatedDevice.IsActive;

            return true;
        }    
    }
   
}
