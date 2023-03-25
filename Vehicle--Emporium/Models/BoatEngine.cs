using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;



namespace Vehicle__Emporium.Models
{
    public class BoatEngine : Engine
    {
        [Display(Name = "Engine Drive Type")]
        [Required(ErrorMessage = "Please enter the drive type of the engine.")]
        [Column(TypeName = "varchar(75)")]
        public string engineDriveType { get; set; }

        [Display(Name = "Propeller Type")]
        [Required(ErrorMessage = "Please enter the propeller type.")]
        [Column(TypeName = "varchar(75)")]
        public string propellerType { get; set; }

        [Display(Name = "Propeller Material")]
        [Required(ErrorMessage = "Please enter the propeller material.")]
        [Column(TypeName = "varchar(75)")]
        public string propellerMaterial { get; set; }

    }
}
