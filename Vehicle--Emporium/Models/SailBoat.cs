using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Vehicle__Emporium.Models
{
    public class SailBoat : Boats
    {
        [Required(ErrorMessage = "Please enter the keel depth.")]
        [Column(TypeName = "int")]
        public int KneelDepth { get; set; }

        [Required(ErrorMessage = "Please enter the number of sails.")]
        [Column(TypeName = "int")]
        public int NumberOfSails { get; set; }

        [Required(ErrorMessage = "Please enter the type of motor.")]
        [Column(TypeName = "varchar(35)")]
        public string? MotorType { get; set; }
    }
}
