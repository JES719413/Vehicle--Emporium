using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using System.Runtime.Intrinsics.X86;
using Vehicle__Emporium.Data;
using Vehicle__Emporium.Models;
using Vehicle__Emporium.ViewModels;

namespace Vehicle__Emporium.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly ApplicationDbContext _context;

        public HomeController(ILogger<HomeController> logger, ApplicationDbContext context)
        {
            _logger = logger;
            _context = context;
        }

        public IActionResult Index()
        {
            List<HomeDisplay> homeDisplays = new List<HomeDisplay>();

            var addBoats = (from B1 in _context.Vehicles
                            join B2 in _context.Boats on B1.vehicleID equals B2.vehicleID
                            select new HomeDisplay
                            {
                                VehicleId = B1.vehicleID,
                                VehicleName = B1.vehicleMake + " " + B1.vehicleModel,
                                ImageUpload = B1.ImageUpload,
                                year = B1.year,
                                price = B1.price,
                                Type = "Boat"
                            }
                            ).Take(3);

            var addCars = (from B1 in _context.Vehicles
                           join B2 in _context.Cars on B1.vehicleID equals B2.vehicleID
                           select new HomeDisplay
                           {
                               VehicleId = B1.vehicleID,
                               VehicleName = B1.vehicleMake + " " + B1.vehicleModel,
                               ImageUpload = B1.ImageUpload,
                               year = B1.year,
                               price = B1.price,
                               Type = "Cars"
                           }
                          ).Take(3);

            var addBikes = (from B1 in _context.Vehicles
                            join B2 in _context.Motorcycles on B1.vehicleID equals B2.vehicleID
                            select new HomeDisplay
                            {
                                VehicleId = B1.vehicleID,
                                VehicleName = B1.vehicleMake + " " + B1.vehicleModel,
                                ImageUpload = B1.ImageUpload,
                                year = B1.year,
                                price = B1.price,
                                Type = "Bikes"
                            }
                          ).Take(3);

            var addMotorH = (from B1 in _context.Vehicles
                             join B2 in _context.MotorHomes on B1.vehicleID equals B2.vehicleID
                             select new HomeDisplay
                             {
                                 VehicleId = B1.vehicleID,
                                 VehicleName = B1.vehicleMake + " " + B1.vehicleModel,
                                 ImageUpload = B1.ImageUpload,
                                 year = B1.year,
                                 price = B1.price,
                                 Type = "MotorHomes"
                             }
                         ).Take(3);
            var addTravel = (from B1 in _context.Vehicles
                             join B2 in _context.TravelTrailer on B1.vehicleID equals B2.vehicleID
                             select new HomeDisplay
                             {
                                 VehicleId = B1.vehicleID,
                                 VehicleName = B1.vehicleMake + " " + B1.vehicleModel,
                                 ImageUpload = B1.ImageUpload,
                                 year = B1.year,
                                 price = B1.price,
                                 Type = "TravelTrailers"
                             }
                        ).Take(3);


            var combined = addBoats.Concat(addCars);
            var combined2 = combined.Concat(addBikes);
            var combined3 = combined2.Concat(addMotorH);
            var final = combined3.Concat(addTravel);


            homeDisplays = final.ToList();
            return View(homeDisplays);
        }

        public IActionResult Privacy()
        {
            return View();
        }
        [Authorize(Roles = "ADMIN")]
        public IActionResult IsAdmin()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }

        public ActionResult BoatDetails(int ID)
        {
            return RedirectToAction("Details", "Boats", new { ID = ID });
        }

        public ActionResult CarDetails(int ID)
        {
            return RedirectToAction("Details", "Cars", new { ID = ID });
        }

        public ActionResult BikeDetails(int ID)
        {
            return RedirectToAction("Details", "Motorcycles", new { ID = ID });
        }

        public ActionResult MHDetails(int ID)
        {
            return RedirectToAction("Details", "MotorHomes", new { ID = ID });
        }

        public ActionResult TTDetails(int ID)
        {
            return RedirectToAction("Details", "TravelTrailers", new { ID = ID });
        }
    }
}