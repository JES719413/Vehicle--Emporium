using System.ComponentModel.DataAnnotations;
using System.Xml.Linq;

namespace Vehicle__Emporium.ViewModels
{
    public class EngineView
    {
        public int engineID { get; set; }
        public int vehicleID { get; set; }

        [Display(Name = "Make: ")]
        public string vehicleMake { get; set; }
        [Required(ErrorMessage = "Please enter the Vehicle model")]

        [Display(Name = "Model: ")]
        public string vehicleModel { get; set; }

        [Display(Name = "Year: ")]
        public int year { get; set; }

        [Display(Name = "Engine Make")]
        public string engineMake { get; set; }

        [Display(Name = "Engine Model")]
        public string engineModel { get; set; }

        [Display(Name = "Engine Power")]
        public int enginePower { get; set; }

        [Display(Name = "Engine Type")]
        public string engineType { get; set; }

        [Display(Name = "Engine Hour")]
        public int engineHour { get; set; }

        public string vehicleType { get; set; }
    }
}
