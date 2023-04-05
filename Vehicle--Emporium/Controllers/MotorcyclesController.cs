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
    public class MotorcyclesController : Controller
    {
        private readonly ApplicationDbContext _context;
        private readonly IWebHostEnvironment _env;
        public MotorcyclesController(ApplicationDbContext context, IWebHostEnvironment env)
        {
            _context = context;
            this._env = env;
        }

        // GET: Motorcycles
        public async Task<IActionResult> Index()
        {
              return _context.Motorcycles != null ? 
                          View(await _context.Motorcycles.ToListAsync()) :
                          Problem("Entity set 'ApplicationDbContext.Motorcycles'  is null.");
        }

        // GET: Motorcycles/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null || _context.Motorcycles == null)
            {
                return NotFound();
            }

            var motorcycles = await _context.Motorcycles
                .FirstOrDefaultAsync(m => m.vehicleID == id);
            if (motorcycles == null)
            {
                return NotFound();
            }

            return View(motorcycles);
        }

        // GET: Motorcycles/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Motorcycles/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(MotorcyclesViewModel model, IFormFile photo)
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

            model.motorcycles.ImageUpload = photo.FileName;
            string currentuser = User.Identity.Name;

            if (model != null)
            {
                var motorcycle = new Motorcycles
                {
                    userID = currentuser,
                    bikeType = model.motorcycles.bikeType,
                    bikeEngineType = model.motorcycles.bikeEngineType,
                    rideHeight = model.motorcycles.rideHeight,
                    chainType = model.motorcycles.chainType,
                    chainLength = model.motorcycles.chainLength,
                    sideCar = model.motorcycles.sideCar,
                    vehicleMake = model.motorcycles.vehicleMake,
                    vehicleModel = model.motorcycles.vehicleModel,
                    year = model.motorcycles.year,
                    miles = model.motorcycles.miles,
                    mpg = model.motorcycles.mpg,
                    condition = model.motorcycles.condition,
                    price = model.motorcycles.price,
                    description = model.motorcycles.description,
                    ImageUpload = fileName,
                };
                _context.Add(motorcycle);
                await _context.SaveChangesAsync();
                
            }
            return RedirectToAction("Index");
        }

        // GET: Motorcycles/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null || _context.Motorcycles == null)
            {
                return NotFound();
            }

            var motorcycles = await _context.Motorcycles.FindAsync(id);
            if (motorcycles == null)
            {
                return NotFound();
            }
            return View(motorcycles);
        }

        // POST: Motorcycles/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("bikeType,bikeEngineType,rideHeight,chainType,chainLength,sideCar,vehicleID,vehicleMake,vehicleModel,year,miles,mpg,condition,price,description,ImageUpload")] Motorcycles motorcycles)
        {
            if (id != motorcycles.vehicleID)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(motorcycles);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!MotorcyclesExists(motorcycles.vehicleID))
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
            return View(motorcycles);
        }

        // GET: Motorcycles/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null || _context.Motorcycles == null)
            {
                return NotFound();
            }

            var motorcycles = await _context.Motorcycles
                .FirstOrDefaultAsync(m => m.vehicleID == id);
            if (motorcycles == null)
            {
                return NotFound();
            }

            return View(motorcycles);
        }

        // POST: Motorcycles/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            if (_context.Motorcycles == null)
            {
                return Problem("Entity set 'ApplicationDbContext.Motorcycles'  is null.");
            }
            var motorcycles = await _context.Motorcycles.FindAsync(id);
            if (motorcycles != null)
            {
                _context.Motorcycles.Remove(motorcycles);
            }
            
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool MotorcyclesExists(int id)
        {
          return (_context.Motorcycles?.Any(e => e.vehicleID == id)).GetValueOrDefault();
        }

        public ActionResult Engine(int ID)
        {
            return RedirectToAction("Create", "Engines", new { ID = ID });
        }
    }
}
