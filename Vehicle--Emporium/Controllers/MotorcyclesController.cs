using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Vehicle__Emporium.Data;
using Vehicle__Emporium.Models;

namespace Vehicle__Emporium.Controllers
{
    public class MotorcyclesController : Controller
    {
        private readonly ApplicationDbContext _context;

        public MotorcyclesController(ApplicationDbContext context)
        {
            _context = context;
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
        public async Task<IActionResult> Create([Bind("bikeType,bikeEngineType,rideHeight,chainType,chainLength,sideCar,vehicleID,vehicleMake,vehicleModel,year,miles,mpg,condition,price,description,ImageUpload")] Motorcycles motorcycles)
        {
            if (ModelState.IsValid)
            {
                _context.Add(motorcycles);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(motorcycles);
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
    }
}
