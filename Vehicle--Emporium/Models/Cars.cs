using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace Vehicle__Emporium.Models
{
    public class Cars : Vehicles
    {
        [Display(Name = "Car Type: ")]
        [Required(ErrorMessage = "Please enter the car type.")]
        [Column(TypeName = "varchar(75)")]
        public string carType { get; set; }
        [Display(Name = "Fuel Capacity: ")]
        [Required(ErrorMessage = "Please enter the fuel capcity.")]
        [Column(TypeName = "int")]
        public int fuelCapcity { get; set; }
        

    }
}
