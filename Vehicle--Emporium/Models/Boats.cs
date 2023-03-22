using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace Vehicle__Emporium.Models
{
    public class Boats : Vehicles
    {
        [Display(Name = "Type")]
        [Required(ErrorMessage = "Please select the type of Boat you have.")]
        [Column(TypeName = "varchar(75)")]
        public string boatType { get; set; }


        [Display(Name = "Class")]
        [Required(ErrorMessage = "Please enter your boat's class.")]
        [Column(TypeName = "varchar(75)")]
        public string boatClass { get; set; }

        [Display(Name = "Length")]
        [Required(ErrorMessage = "Please enter your boat's length.")]
        [Column(TypeName = "int")]
        public int boatLength { get; set; }

        [Display(Name = "Fuel")]
        [Required(ErrorMessage = "Please select the type of fuel the boat uses.")]
        [Column(TypeName = "varchar(75)")]
        public string boatFuel { get; set; }

        [Display(Name = "Fuel Tank Size")]
        [Required(ErrorMessage = "Please enter the size of the boats fuel tanks in gallons.")]
        [Column(TypeName = "int")]
        public int boatFuelTanks { get; set; }

        [Display(Name = "Hull Material")]
        [Required(ErrorMessage = "Please enter the hull material.")]
        [Column(TypeName = "varchar(75)")]
        public string boatMaterial { get; set; }

        [Display(Name = "Hull Shape")]
        [Required(ErrorMessage = "Please enter the hull shape.")]
        [Column(TypeName = "varchar(75)")]
        public string boatShape { get; set; }

        [Display(Name = "Capcity")]
        [Required(ErrorMessage = "Please enter the seating capacity of your boat")]
        [Column(TypeName = "int")]
        public int boatCapcity { get; set; }


    }

}
