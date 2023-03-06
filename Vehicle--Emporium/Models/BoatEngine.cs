using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;



namespace Vehicle__Emporium.Models
{
    public class BoatEngine : Engine
    {

        [Required(ErrorMessage = "Please enter the drive type of the engine.")]
        [Column(TypeName = "varchar(75)")]
        public string engineDriveType { get; set; }

        [Required(ErrorMessage = "Please enter the propeller type.")]
        [Column(TypeName = "varchar(75)")]
        public string propellerType { get; set; }

        [Required(ErrorMessage = "Please enter the propeller material.")]
        [Column(TypeName = "varchar(75)")]
        public string propellerMaterial { get; set; }

    }
}
