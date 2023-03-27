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
    public class BoatsController : Controller
    {
        private readonly ApplicationDbContext _context;
        private readonly IWebHostEnvironment _env;

        public BoatsController(ApplicationDbContext context, IWebHostEnvironment env)
        {
            _context = context;
            this._env = env;
        }

        // GET: Boats
        public async Task<IActionResult> Index()
        {
            return _context.Boats != null ?
                        View(await _context.Boats.ToListAsync()) :
                        Problem("Entity set 'ApplicationDbContext.Boats'  is null.");


        }

        public ActionResult Test()
        {
            var model = new BoatEngineViewModel
            {
                BoatEngine = _context.BoatEngines.ToList(),
                Engine = _context.Engines.ToList()

            };

            IQueryable<Boats> query = _context.Boats;
            model.Boats = query.ToList();
            return View(model);
        }


        // GET: Boats/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null || _context.Boats == null)
            {
                return NotFound();
            }

            var boats = await _context.Boats
                .FirstOrDefaultAsync(m => m.vehicleID == id);
            if (boats == null)
            {
                return NotFound();
            }

            return View(boats);
        }

        // GET: Boats/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Boats/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(BoatsViewModel model, IFormFile photo)
        {
            if (photo == null || photo.Length == 0)
            {
                return Content("File Not Selected");
            }
            string rootpath = _env.WebRootPath;
            string fileName = Path.GetFileNameWithoutExtension(photo.FileName);
            string extension = Path.GetExtension(photo.FileName);
            var path = Path.Combine(rootpath + "/Images/", fileName);
            // var path = Path.Combine(_env.WebRootPath, "ImageName/Cover", photo.FileName);
            using (FileStream stream = new FileStream(path, FileMode.Create))
            {
                await photo.CopyToAsync(stream);
                stream.Close();
            }

            model.boats.ImageUpload = photo.FileName;
           if (model != null)
            {
                var boat = new Boats
                {
                    boatType = model.boats.boatType,
                    boatClass = model.boats.boatClass,
                    boatLength = model.boats.boatLength,
                    boatFuel = model.boats.boatFuel,
                    boatFuelTanks = model.boats.boatFuelTanks,
                    boatMaterial = model.boats.boatMaterial,
                    boatShape = model.boats.boatShape,
                    boatCapcity = model.boats.boatCapcity,
                    vehicleMake = model.boats.vehicleMake,
                    vehicleModel = model.boats.vehicleModel,
                    year = model.boats.year,
                    miles = model.boats.miles,
                    mpg = model.boats.mpg,
                    condition = model.boats.condition,
                    price = model.boats.price,
                    description = model.boats.description,
                    ImageUpload = path
                };
                _context.Add(boat);
                await _context.SaveChangesAsync();
            }
            return RedirectToAction("Index");
        }

        // GET: Boats/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            ViewBag.Test = id;
            if (id == null || _context.Boats == null)
            {
                return NotFound();
            }

            var boats = await _context.Boats.FindAsync(id);
            if (boats == null)
            {
                return NotFound();
            }
            return View(boats);
        }

        // POST: Boats/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("boatType,boatClass,boatLength,boatFuel,boatFuelTanks,boatMaterial,boatShape,boatCapcity,vehicleID,vehicleMake,vehicleModel,year,miles,mpg,condition,price,description,ImageUpload")] Boats boats)
        {
            if (id != boats.vehicleID)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(boats);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!BoatsExists(boats.vehicleID))
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
            return View(boats);
        }

        // GET: Boats/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null || _context.Boats == null)
            {
                return NotFound();
            }

            var boats = await _context.Boats
                .FirstOrDefaultAsync(m => m.vehicleID == id);
            if (boats == null)
            {
                return NotFound();
            }

            return View(boats);
        }

        // POST: Boats/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            if (_context.Boats == null)
            {
                return Problem("Entity set 'ApplicationDbContext.Boats'  is null.");
            }
            var boats = await _context.Boats.FindAsync(id);
            if (boats != null)
            {
                _context.Boats.Remove(boats);
            }
            
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool BoatsExists(int id)
        {
          return (_context.Boats?.Any(e => e.vehicleID == id)).GetValueOrDefault();
        }

        public ActionResult BoatEngine(int ID)
        {
            return RedirectToAction("Create", "BoatEngines", new { ID = ID });
        }
    }
}
