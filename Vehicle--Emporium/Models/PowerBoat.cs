using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Vehicle__Emporium.Models
{
    public class PowerBoat : Boats
    {
        [Required(ErrorMessage = "Please enter the number of engines.")]
        [Column(TypeName = "int")]
        public int NumberOfEngines { get; set; }

        [Required(ErrorMessage = "Please enter the Fuel Type.")]
        [Column(TypeName = "varchar(50)")]
        public string FuelType { get; set; }
    }
}
