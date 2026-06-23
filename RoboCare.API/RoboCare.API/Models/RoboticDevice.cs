using System.ComponentModel.DataAnnotations;


namespace RoboCare.API.Models
{
    public class RoboticDevice
    {
        [Required]
        public int ID { get; set; }
        public string Model { get; set; }
        public string SerialNumber { get; set; }
        public DateTime LastCalibrationDate { get; set; }   
        public bool IsActive { get; set; }

    }
}
