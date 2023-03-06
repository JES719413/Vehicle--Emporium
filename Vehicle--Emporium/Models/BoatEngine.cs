using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;



namespace Vehicle__Emporium.Models
{
    public class BoatEngine : Engine
    {
        [Required(ErrorMessage = "Please enter the number of hours on the engine.")]
        [Column(TypeName = "int")]
        public int engineHour { get; set; }

        [Required(ErrorMessage = "Please enter the drive type of the engine.")]
        [Column(TypeName = "varchar(75)")]
        public int engineDriveType { get; set; }

        [Required(ErrorMessage = "Please enter the propeller type.")]
        [Column(TypeName = "varchar(75)")]
        public int propellerType { get; set; }

        [Required(ErrorMessage = "Please enter the propeller material.")]
        [Column(TypeName = "varchar(75)")]
        public int propellerMaterial { get; set; }

    }
}
