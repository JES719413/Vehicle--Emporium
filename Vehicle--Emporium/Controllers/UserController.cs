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
            return _context.Vehicles != null ?
                       View(await _context.Vehicles.ToListAsync()) :
                       Problem("Entity set 'ApplicationDbContext.Boats'  is null.");

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
    }

}
