using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Vehicle__Emporium.Models
{
    public class Vehicles
    {
        [Key]
        public int vehicleID { get; set; }
        [Required(ErrorMessage = "Please enter the make of the Vehicle.")]
        public string vehicleMake { get; set; }
        [Required(ErrorMessage = "Please enter the Vehicle model")]
        public string vehicleModel { get; set; }
        [Required(ErrorMessage = "Please enter the year of the Vehicle.")]
        public int year { get; set; }
        [Required(ErrorMessage = "Please enter how many miles the Vehicle has.")]
        [Range(0, 500000, ErrorMessage = "Miles can not exceed over 500,000.")]
        public int miles { get; set; }
        [Required(ErrorMessage = "Please enter the miles per gallon.")]

        public int mpg { get; set; }
        [Required(ErrorMessage = "Please enter the condition of the Vehicle.")]
        public string condition { get; set; }
        [Required(ErrorMessage = "Please enter a price.")]
        [Column(TypeName = "decimal(18,2)")]
        public decimal price { get; set; }
        public string description { get; set; }
        
        [DisplayName("Item Image")]
        public string ImageUpload { get; set; }

        [NotMapped]
        [DisplayName("Image")]
        public IFormFile Image { get; set; }
    }
}
