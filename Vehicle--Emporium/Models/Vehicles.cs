using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Vehicle__Emporium.Models
{
    public class Vehicles
    {
        [Key]
        [Display(Name = "Vehicle ID: ")]
        public int vehicleID { get; set; }

        [Display(Name = "Seller: ")]
        public string userID { get; set; }

        [Display(Name = "Make: ")]
        [Required(ErrorMessage = "Please enter the make of the Vehicle.")]
        public string vehicleMake { get; set; }
        [Required(ErrorMessage = "Please enter the Vehicle model")]

        [Display(Name = "Model: ")]
        public string vehicleModel { get; set; }
        [Required(ErrorMessage = "Please enter the year of the Vehicle.")]

        [Display(Name = "Year: ")]
        public int year { get; set; }
        [Required(ErrorMessage = "Please enter how many miles the Vehicle has.")]
        [Range(0, 500000, ErrorMessage = "Miles can not exceed over 500,000.")]

        [Display(Name = "Miles: ")]
        public int miles { get; set; }

        [Required(ErrorMessage = "Please enter the miles per gallon.")]
        [Display(Name = "MPG: ")]
        public int mpg { get; set; }

        [Display(Name = "Condition: ")]
        [Required(ErrorMessage = "Please enter the condition of the Vehicle.")]
        public string condition { get; set; }

        [Display(Name = "Price: ")]
        [Required(ErrorMessage = "Please enter a price.")]
        [Column(TypeName = "decimal(18,2)")]
        public decimal price { get; set; }

        [Display(Name = "Description: ")]
        public string description { get; set; }

        [Display(Name = "Image: ")]
        [DisplayName("Item Image")]
        public string ImageUpload { get; set; }

        public int engineAdded { get; set; }

       
    }
}
