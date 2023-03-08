using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace Vehicle__Emporium.Models
{
    public class Motorcycles : Vehicles
    {
        [Required(ErrorMessage = "Please enter the type of bike.")]
        [Column(TypeName = "varchar(75)")]
        public string bikeType { get; set;}
        [Required(ErrorMessage = "Please enter the type of engine.")]
        [Column(TypeName = "varchar(75)")]
        public string bikeEngineType { get; set; }
        [Required(ErrorMessage = "Please enter the bike's ride height.")]
        [Column(TypeName = "int")]
        public int rideHeight { get; set; }
        [Required(ErrorMessage = "Please enter the chain type.")]
        [Column(TypeName = "varchar(75)")]
        public string chainType { get; set; }
        [Required(ErrorMessage = "Please enter the chain length.")]
        [Column(TypeName ="int")]
        public int chainLength { get; set; }
        [Required(ErrorMessage = "Please enter if the bike has a sidecar.")]
        [Column(TypeName = "int")]
        public int sideCar { get; set; }

    }
}
