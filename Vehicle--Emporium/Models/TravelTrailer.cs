using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Vehicle__Emporium.Models
{
    public class TravelTrailer : Vehicles
    {
        public int motorHomeId { get; set; }

        public int vehicleID { get; set; }
        [Required(ErrorMessage = "Please select the RV class.")]
        [Column(TypeName = "varchar(75)")]
        public string rvClass { get; set; }
        [Required(ErrorMessage = "Please enter the length of the motor home")]
        [Column(TypeName = "int")]
        public double length { get; set; }

        [Required(ErrorMessage = "Please select amount of slide outs.")]
        [Column(TypeName = "int")]
        public int slideOuts { get; set; }
        [Required(ErrorMessage = "Please enter the dry wieght.")]
        [Column(TypeName = "double")]
        public double dryWeight { get; set; }


    }
}
