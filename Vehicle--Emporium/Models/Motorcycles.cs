using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace Vehicle__Emporium.Models
{
    public class Motorcycles : Vehicles
    {
        [Display(Name = "Bike Type: ")]
        [Required(ErrorMessage = "Please enter the type of bike.")]
        [Column(TypeName = "varchar(75)")]
        public string bikeType { get; set;}
        [Display(Name ="Engine Type: ")]
        [Required(ErrorMessage = "Please enter the type of engine.")]
        [Column(TypeName = "varchar(75)")]
        public string bikeEngineType { get; set; }
        [Display(Name = "Ride Height: ")]
        [Required(ErrorMessage = "Please enter the bike's ride height.")]
        [Column(TypeName = "int")]
        public int rideHeight { get; set; }
        [Display(Name ="Chain Type: ")]
        [Required(ErrorMessage = "Please enter the chain type.")]
        [Column(TypeName = "varchar(75)")]
        public string chainType { get; set; }
        [Display(Name = "Chain Length: ")]
        [Required(ErrorMessage = "Please enter the chain length.")]
        [Column(TypeName ="int")]
        public int chainLength { get; set; }
        [Display(Name = "Side Car: ")]
        [Required(ErrorMessage = "Please enter if the bike has a sidecar.")]
        [Column(TypeName = "int")]
        public int sideCar { get; set; }

    }
}
