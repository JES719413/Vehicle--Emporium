using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Vehicle__Emporium.Data;
using Vehicle__Emporium.Models;
using Vehicle__Emporium.ViewModels;

namespace Vehicle__Emporium.Controllers
{
    public class CarsController : Controller
    {
        private readonly ApplicationDbContext _context;
        private readonly IWebHostEnvironment _env;
        public CarsController(ApplicationDbContext context, IWebHostEnvironment env)
        {
            _context = context;
            this._env = env;
        }

        // GET: Cars
        public async Task<IActionResult> Index()
        {
              return _context.Cars != null ? 
                          View(await _context.Cars.ToListAsync()) :
                          Problem("Entity set 'ApplicationDbContext.Cars'  is null.");
        }

        // GET: Cars/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null || _context.Cars == null)
            {
                return NotFound();
            }

            var cars = await _context.Cars
                .FirstOrDefaultAsync(m => m.vehicleID == id);
            if (cars == null)
            {
                return NotFound();
            }

            return View(cars);
        }

        // GET: Cars/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Cars/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(CarsViewModel model, IFormFile photo)
        {
            if (photo == null || photo.Length == 0)
            {
                return Content("File Not Selected");
            }
            string rootpath = _env.WebRootPath;
            string fileName = Path.GetFileNameWithoutExtension(photo.FileName);
            string extension = Path.GetExtension(photo.FileName);
            var path = Path.Combine(rootpath + "/Images/", fileName + ".jpeg");
            // var path = Path.Combine(_env.WebRootPath, "ImageName/Cover", photo.FileName);
            using (FileStream stream = new FileStream(path, FileMode.Create))
            {
                await photo.CopyToAsync(stream);
                stream.Close();
            }

            model.cars.ImageUpload = photo.FileName;
            string currentuser = User.Identity.Name;

            if (model != null)
            {
                var cars = new Cars
                {
                    userID = currentuser,
                    carType = model.cars.carType,
                    fuelCapcity = model.cars.fuelCapcity,
                    vehicleMake = model.cars.vehicleMake,
                    vehicleModel = model.cars.vehicleModel,
                    year = model.cars.year,
                    miles = model.cars.miles,
                    mpg = model.cars.mpg,
                    condition = model.cars.condition,
                    price = model.cars.price,
                    description = model.cars.description,
                    ImageUpload = fileName,
                };
                _context.Add(cars);
                await _context.SaveChangesAsync();
            }
            return RedirectToAction("Index");
        }

        // GET: Cars/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null || _context.Cars == null)
            {
                return NotFound();
            }

            var cars = await _context.Cars.FindAsync(id);
            if (cars == null)
            {
                return NotFound();
            }
            return View(cars);
        }

        // POST: Cars/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("carType,fuelCapcity,vehicleID,vehicleMake,vehicleModel,year,miles,mpg,condition,price,description,ImageUpload,userID")] Cars cars)
        {
            if (id != cars.vehicleID)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(cars);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!CarsExists(cars.vehicleID))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            return View(cars);
        }

        // GET: Cars/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null || _context.Cars == null)
            {
                return NotFound();
            }

            var cars = await _context.Cars
                .FirstOrDefaultAsync(m => m.vehicleID == id);
            if (cars == null)
            {
                return NotFound();
            }

            return View(cars);
        }

        // POST: Cars/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            if (_context.Cars == null)
            {
                return Problem("Entity set 'ApplicationDbContext.Cars'  is null.");
            }
            var cars = await _context.Cars.FindAsync(id);
            if (cars != null)
            {
                _context.Cars.Remove(cars);
            }
            
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool CarsExists(int id)
        {
          return (_context.Cars?.Any(e => e.vehicleID == id)).GetValueOrDefault();
        }

        public ActionResult Engine(int ID)
        {
            return RedirectToAction("Create", "Engines", new { ID = ID });
        }
    }
}
