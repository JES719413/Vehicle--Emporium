using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace Vehicle__Emporium.Models
{
    public class Boats : Vehicles
    {
        [Required(ErrorMessage = "Please select the type of Boat you have.")]
        [Column(TypeName = "varchar(75)")]
        public string boatType { get; set; }

        [Required(ErrorMessage = "Please enter your boat's class.")]
        [Column(TypeName = "varchar(75)")]
        public string boatClass { get; set; }

        [Required(ErrorMessage = "Please enter your boat's length.")]
        [Column(TypeName = "int")]
        public int boatLength { get; set; }

        [Required(ErrorMessage = "Please select the type of fuel the boat uses.")]
        [Column(TypeName = "varchar(75)")]
        public string boatFuel { get; set; }

        [Required(ErrorMessage = "Please enter the size of the boats fuel tanks in gallons.")]
        [Column(TypeName = "int")]
        public int boatFuelTanks { get; set; }

        [Required(ErrorMessage = "Please enter the hull material.")]
        [Column(TypeName = "varchar(75)")]
        public string boatMaterial { get; set; }

        [Required(ErrorMessage = "Please enter the hull shape.")]
        [Column(TypeName = "varchar(75)")]
        public string boatShape { get; set; }

        [Required(ErrorMessage = "Please enter the seating capacity of your boat")]
        [Column(TypeName = "int")]
        public int boatCapcity { get; set; }


    }

}
