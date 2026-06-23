using System.ComponentModel.DataAnnotations;


namespace RoboCare.API.Models
{
    public class RoboticDevice
    {
        public int ID { get; set; }
        public string Model { get; set; }
        public int SerialNumber { get; set; }
        public DateTime LastCalibrationDate { get; set; }   
        public bool IsActive { get; set; }

    }
}
