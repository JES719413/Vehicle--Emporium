using System.ComponentModel.DataAnnotations;

namespace Vehicle__Emporium.Models
{
    public class Vehicles
    {
        public int carID { get; set; }
        [Required(ErrorMessage = "Please enter the make of the car.")]
        public string carMake { get; set; }
        [Required(ErrorMessage = "Please enter the car model")]
        public string carModel { get; set; }
        [Required(ErrorMessage = "Please enter the year of the car.")]
        public int? year { get; set; }
        [Required(ErrorMessage = "Please enter how many miles the car has.")]
        [Range(0, 500000, ErrorMessage = "Miles can not exceed over 500,000.")]
        public int miles { get; set; }
        [Required(ErrorMessage = "Please enter the miles per gallon.")]

        public int mpg { get; set; }
        [Required(ErrorMessage = "Please enter the condition of the car.")]
        public string condition { get; set; }
        [Required(ErrorMessage = "Please enter a price.")]
        public decimal price { get; set; }

        public string description { get; set; }
    }
}
