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
    public class EnginesController : Controller
    {
        private readonly ApplicationDbContext _context;

        public EnginesController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: Engines
        public async Task<IActionResult> Index()
        {
              return _context.Engines != null ? 
                          View(await _context.Engines.ToListAsync()) :
                          Problem("Entity set 'ApplicationDbContext.Engines'  is null.");
        }

        // GET: Engines/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null || _context.Engines == null)
            {
                return NotFound();
            }

            var engine = await _context.Engines
                .FirstOrDefaultAsync(m => m.vehicleID == id);
            if (engine == null)
            {
                return NotFound();
            }

            return View(engine);
        }

        // GET: Engines/Create
        public async Task<IActionResult> Create(int? ID)
        {
            ViewBag.ID = ID;

            return View();
        }

        // POST: Engines/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("engineID,vehicleID,engineMake,engineModel,enginePower,engineType,engineHour")] Engine engine)
        {
            if (ModelState.IsValid)
            {

                var vehicle = _context.Vehicles.Where(c => c.vehicleID == engine.vehicleID).FirstOrDefault();
                if (vehicle != null)
                {
                    vehicle.engineAdded = 1;
                }
                _context.Add(engine);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(engine);
        }

        // GET: Engines/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null || _context.Engines == null)
            {
                return NotFound();
            }

            var engine = await _context.Engines.FindAsync(id);
            if (engine == null)
            {
                return NotFound();
            }
            return View(engine);
        }

        // POST: Engines/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("engineID,vehicleID,engineMake,engineModel,enginePower,engineType,engineHour")] Engine engine)
        {
            if (id != engine.engineID)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {  
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!EngineExists(engine.engineID))
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
            return View(engine);
        }

        // GET: Engines/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null || _context.Engines == null)
            {
                return NotFound();
            }

            var engine = await _context.Engines
                .FirstOrDefaultAsync(m => m.engineID == id);
            if (engine == null)
            {
                return NotFound();
            }

            return View(engine);
        }

        // POST: Engines/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            if (_context.Engines == null)
            {
                return Problem("Entity set 'ApplicationDbContext.Engines'  is null.");
            }
            var engine = await _context.Engines.FindAsync(id);
            if (engine != null)
            {
                _context.Engines.Remove(engine);
            }
            
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool EngineExists(int id)
        {
          return (_context.Engines?.Any(e => e.engineID == id)).GetValueOrDefault();
        }
    }
}
