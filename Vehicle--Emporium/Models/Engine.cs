using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;


namespace Vehicle__Emporium.Models
{
    public class Engine
    {
        public int engineID { get; set; }
        public int vehicleID { get; set; }

        [Required(ErrorMessage = "Please enter the make of the engine.")]
        [Column(TypeName = "varchar(75)")]
        public string engineMake { get; set; }

        [Required(ErrorMessage = "Please enter the model of the engine.")]
        [Column(TypeName = "varchar(75)")]
        public string engineModel { get; set; }

        [Required(ErrorMessage = "Please enter the power of the engine(in horsepower).")]
        [Column(TypeName = "int")]
        public int enginePower { get; set; }

        [Required(ErrorMessage = "Please enter the type of engine.")]
        [Column(TypeName = "varchar(75)")]
        public int engineType { get; set; }

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
