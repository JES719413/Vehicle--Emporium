using System.Security.Cryptography.X509Certificates;
using Vehicle__Emporium.Models;

namespace Vehicle__Emporium.ViewModels
{
    public class HomeDisplay
    {
        public int VehicleId { get; set; }
        public string VehicleName { get; set; }
        public int year { get; set; }

        public decimal price { get; set; }
        public string Type { get; set; }
        public string ImageUpload { get; set; }

        public string Id { get; set; }

        public string HasEngine { get; set; }
    }
}
