using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using System.Runtime.Intrinsics.X86;
using Vehicle__Emporium.Data;
using Vehicle__Emporium.Models;
using Vehicle__Emporium.ViewModels;
using Vehicle__Emporium.Areas.Identity;
using Microsoft.EntityFrameworkCore;

namespace Vehicle__Emporium.Controllers
{
    public class UserController : Controller
    {

        private readonly ILogger<HomeController> _logger;
        private readonly ApplicationDbContext _context;

        public UserController(ILogger<HomeController> logger, ApplicationDbContext context)
        {
            _logger = logger;
            _context = context;
        }

        public async Task<IActionResult> Index()
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
                                Type = "Boat",
                                Id = B1.userID,
                                HasEngine = B1.engineAdded,
                            }
                            );

            var addCars = (from B1 in _context.Vehicles
                           join B2 in _context.Cars on B1.vehicleID equals B2.vehicleID
                           select new HomeDisplay
                           {
                               VehicleId = B1.vehicleID,
                               VehicleName = B1.vehicleMake + " " + B1.vehicleModel,
                               ImageUpload = B1.ImageUpload,
                               year = B1.year,
                               price = B1.price,
                               Type = "Cars",
                               Id = B1.userID,
                               HasEngine = B1.engineAdded,
                           }
                          );

            var addBikes = (from B1 in _context.Vehicles
                            join B2 in _context.Motorcycles on B1.vehicleID equals B2.vehicleID
                            select new HomeDisplay
                            {
                                VehicleId = B1.vehicleID,
                                VehicleName = B1.vehicleMake + " " + B1.vehicleModel,
                                ImageUpload = B1.ImageUpload,
                                year = B1.year,
                                price = B1.price,
                                Type = "Bikes",
                                Id = B1.userID,
                                HasEngine = B1.engineAdded,
                            }
                          );

            var addMotorH = (from B1 in _context.Vehicles
                             join B2 in _context.MotorHomes on B1.vehicleID equals B2.vehicleID
                             select new HomeDisplay
                             {
                                 VehicleId = B1.vehicleID,
                                 VehicleName = B1.vehicleMake + " " + B1.vehicleModel,
                                 ImageUpload = B1.ImageUpload,
                                 year = B1.year,
                                 price = B1.price,
                                 Type = "MotorHomes",
                                 Id = B1.userID,
                                 HasEngine = B1.engineAdded,
                             }
                         );
            var addTravel = (from B1 in _context.Vehicles
                             join B2 in _context.TravelTrailer on B1.vehicleID equals B2.vehicleID
                             select new HomeDisplay
                             {
                                 VehicleId = B1.vehicleID,
                                 VehicleName = B1.vehicleMake + " " + B1.vehicleModel,
                                 ImageUpload = B1.ImageUpload,
                                 year = B1.year,
                                 price = B1.price,
                                 Type = "TravelTrailers",
                                 Id = B1.userID,
                                 HasEngine = B1.engineAdded,
                             }
                        );


            var combined = addBoats.Concat(addCars);
            var combined2 = combined.Concat(addBikes);
            var combined3 = combined2.Concat(addMotorH);
            var final = combined3.Concat(addTravel);


            homeDisplays = final.ToList();
            return View(homeDisplays);


        }

        public ActionResult CreateCar()
        {
            return RedirectToAction("Create", "Cars");

        }

        public ActionResult CreateBoat()
        {
            return RedirectToAction("Create", "Boats");

        }

        public ActionResult CreateBike()
        {
            return RedirectToAction("Create", "Motorcycles");

        }
        public ActionResult createMH()
        {
            return RedirectToAction("Create", "MotorHomes");

        }
        public ActionResult CreateTT()
        {
            return RedirectToAction("Create", "TravelTrailers");

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

        public ActionResult BoatEdit(int ID)
        {
            return RedirectToAction("Edit", "Boats", new { ID = ID });
        }

        public ActionResult CarEdit(int ID)
        {
            return RedirectToAction("Edit", "Cars", new { ID = ID });
        }

        public ActionResult BikeEdit(int ID)
        {
            return RedirectToAction("Edit", "Motorcycles", new { ID = ID });
        }

        public ActionResult MHEdit(int ID)
        {
            return RedirectToAction("Edit", "MotorHomes", new { ID = ID });
        }

        public ActionResult TTEdit(int ID)
        {
            return RedirectToAction("Edit", "TravelTrailers", new { ID = ID });
        }

        public ActionResult BoatDelete(int ID)
        {
            return RedirectToAction("Delete", "Boats", new { ID = ID });
        }

        public ActionResult CarDelete(int ID)
        {
            return RedirectToAction("Delete", "Cars", new { ID = ID });
        }

        public ActionResult BikeDelete(int ID)
        {
            return RedirectToAction("Delete", "Motorcycles", new { ID = ID });
        }

        public ActionResult MHDelete(int ID)
        {
            return RedirectToAction("Delete", "MotorHomes", new { ID = ID });
        }

        public ActionResult TTDelete(int ID)
        {
            return RedirectToAction("Delete", "TravelTrailers", new { ID = ID });
        }

        public ActionResult Engine(int ID)
        {
            return RedirectToAction("Create", "Engines", new { ID = ID });
        }

        public ActionResult BoatEngine(int ID)
        {
            return RedirectToAction("Create", "BoatEngines", new { ID = ID });
        }

        public ActionResult EditEngine(int ID)
        {
            return RedirectToAction("Edit", "Engines", new { ID = ID });
        }

        public ActionResult DeleteEngine(int ID)
        {
            return RedirectToAction("Delete", "Engines", new { ID = ID });
        }

        public ActionResult EditBEngine(int ID)
        {
            return RedirectToAction("Edit", "BoatEngines", new { ID = ID });
        }

        public ActionResult DeleteBEngine(int ID)
        {
            return RedirectToAction("Delete", "BoatEngines", new { ID = ID });
        }
    }

}
