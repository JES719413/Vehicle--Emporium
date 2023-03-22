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
    public class TravelTrailersController : Controller
    {
        private readonly ApplicationDbContext _context;
        private readonly IWebHostEnvironment _env;
        public TravelTrailersController(ApplicationDbContext context, IWebHostEnvironment env)
        {
            _context = context;
            this._env = env;
        }

        // GET: TravelTrailers
        public async Task<IActionResult> Index()
        {
              return _context.TravelTrailer != null ? 
                          View(await _context.TravelTrailer.ToListAsync()) :
                          Problem("Entity set 'ApplicationDbContext.TravelTrailer'  is null.");
        }

        // GET: TravelTrailers/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null || _context.TravelTrailer == null)
            {
                return NotFound();
            }

            var travelTrailer = await _context.TravelTrailer
                .FirstOrDefaultAsync(m => m.vehicleID == id);
            if (travelTrailer == null)
            {
                return NotFound();
            }

            return View(travelTrailer);
        }

        // GET: TravelTrailers/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: TravelTrailers/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(TravelTrailerViewModel model, IFormFile photo)
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

            model.travelTrailer.ImageUpload = photo.FileName;



            if (model != null)
            {
                var travelTrailer = new TravelTrailer
                {
                    rvClass = model.travelTrailer.rvClass,
                    length = model.travelTrailer.length,
                    slideOuts = model.travelTrailer.slideOuts,
                    dryWeight = model.travelTrailer.dryWeight,
                    vehicleMake = model.travelTrailer.vehicleMake,
                    vehicleModel = model.travelTrailer.vehicleModel,
                    year = model.travelTrailer.year,
                    miles = model.travelTrailer.miles,
                    mpg = model.travelTrailer.mpg,
                    condition = model.travelTrailer.condition,
                    price = model.travelTrailer.price,
                    description = model.travelTrailer.description,
                    ImageUpload = path,
                };

                _context.Add(travelTrailer);
                await _context.SaveChangesAsync();
                
            }
            return RedirectToAction("Index");
        }

        // GET: TravelTrailers/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null || _context.TravelTrailer == null)
            {
                return NotFound();
            }

            var travelTrailer = await _context.TravelTrailer.FindAsync(id);
            if (travelTrailer == null)
            {
                return NotFound();
            }
            return View(travelTrailer);
        }

        // POST: TravelTrailers/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("rvClass,length,slideOuts,dryWeight,vehicleID,vehicleMake,vehicleModel,year,miles,mpg,condition,price,description,ImageUpload")] TravelTrailer travelTrailer)
        {
            if (id != travelTrailer.vehicleID)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(travelTrailer);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!TravelTrailerExists(travelTrailer.vehicleID))
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
            return View(travelTrailer);
        }

        // GET: TravelTrailers/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null || _context.TravelTrailer == null)
            {
                return NotFound();
            }

            var travelTrailer = await _context.TravelTrailer
                .FirstOrDefaultAsync(m => m.vehicleID == id);
            if (travelTrailer == null)
            {
                return NotFound();
            }

            return View(travelTrailer);
        }

        // POST: TravelTrailers/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            if (_context.TravelTrailer == null)
            {
                return Problem("Entity set 'ApplicationDbContext.TravelTrailer'  is null.");
            }
            var travelTrailer = await _context.TravelTrailer.FindAsync(id);
            if (travelTrailer != null)
            {
                _context.TravelTrailer.Remove(travelTrailer);
            }
            
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool TravelTrailerExists(int id)
        {
          return (_context.TravelTrailer?.Any(e => e.vehicleID == id)).GetValueOrDefault();
        }
    }
}
