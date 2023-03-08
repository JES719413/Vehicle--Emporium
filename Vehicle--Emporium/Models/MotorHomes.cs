using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Vehicle__Emporium.Models
{
    public class MotorHomes : Vehicles

    {
        [Required(ErrorMessage = "Please select amount of slide outs.")]
        [Column(TypeName = "int")]
        public int slideOuts { get; set; }
        [Required(ErrorMessage = "Please enter amount of people it can sleep.")]
        [Column(TypeName = "int")]
        public int sleeps { get; set; }
        [Required(ErrorMessage = "Please select the type of fuel.")]
        [Column(TypeName = "varchar(75)")]
        public string fuelType { get; set; }
        [Required(ErrorMessage = "Please select the RV class.")]
        [Column(TypeName = "varchar(75)")]
        public string rvClass { get; set; }
        [Required(ErrorMessage = "Please enter the length of the motor home")]
        [Column(TypeName = "double")]
        public double length { get; set; }

        public MotorHomes() { }


    }
}
