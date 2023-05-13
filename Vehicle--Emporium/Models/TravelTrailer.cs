using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Vehicle__Emporium.Models
{
    public class TravelTrailer : Vehicles
    {
        [Display(Name = "RV Class: ")]
        [Required(ErrorMessage = "Please select the RV class.")]
        [Column(TypeName = "varchar(75)")]
        public string rvClass { get; set; }
        [Display(Name = "Length: ")]
        [Required(ErrorMessage = "Please enter the length of the motor home")]
        [Column(TypeName = "decimal(18,2)")]
        public decimal length { get; set; }
        [Display(Name = "Slide Outs: ")]
        [Required(ErrorMessage = "Please select amount of slide outs.")]
        [Column(TypeName = "int")]
        public int slideOuts { get; set; }
        [Display(Name = "Dry Weight: ")]
        [Required(ErrorMessage = "Please enter the dry wieght.")]
        [Column(TypeName = "decimal(18,2)")]
        public decimal dryWeight { get; set; }


    }
}
