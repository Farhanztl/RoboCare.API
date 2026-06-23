using System.ComponentModel.DataAnnotations;


namespace RoboCare.API.Models
{
    public class RoboticDevice
    {
        [Required(ErrorMessage = "Please give your ID")]
        [Display(Name = "Robot ID")]
        public int ID { get; set; }

        [Required(ErrorMessage = "Please give your Model")]
        public string Model { get; set; }

        [Required(ErrorMessage = "Please give your SerialNumber")]
        public string SerialNumber { get; set; }

        [Required(ErrorMessage = "Please give your DateTime")]
        public DateTime LastCalibrationDate { get; set; }

        [Required(ErrorMessage = "Please give your Activity Situation")]
        public bool IsActive { get; set; }

    }
}
