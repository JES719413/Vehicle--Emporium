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
    public class BoatEnginesController : Controller
    {
        private readonly ApplicationDbContext _context;

        public BoatEnginesController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: BoatEngines
        public async Task<IActionResult> Index()
        {
              return _context.BoatEngines != null ? 
                          View(await _context.BoatEngines.ToListAsync()) :
                          Problem("Entity set 'ApplicationDbContext.BoatEngines'  is null.");
        }

        // GET: BoatEngines/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null || _context.BoatEngines == null)
            {
                return NotFound();
            }

            var boatEngine = await _context.BoatEngines
                .FirstOrDefaultAsync(m => m.engineID == id);
            if (boatEngine == null)
            {
                return NotFound();
            }

            return View(boatEngine);
        }

        //// GET: BoatEngines/Create
        //public IActionResult Create()
        //{
        //    return View();
        //    return View();
        //}

        public async Task<IActionResult> Create(int? ID)
        {
            ViewBag.ID = ID;

            return View();
        }

        // POST: BoatEngines/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("engineDriveType,propellerType,propellerMaterial,engineID,vehicleID,engineMake,engineModel,enginePower,engineType,engineHour")] BoatEngine boatEngine)
        {
            if (ModelState.IsValid)
            {
                _context.Add(boatEngine);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(boatEngine);
        }

        // GET: BoatEngines/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null || _context.BoatEngines == null)
            {
                return NotFound();
            }

            var boatEngine = await _context.BoatEngines.FindAsync(id);
            if (boatEngine == null)
            {
                return NotFound();
            }
            return View(boatEngine);
        }

        // POST: BoatEngines/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("engineDriveType,propellerType,propellerMaterial,engineID,vehicleID,engineMake,engineModel,enginePower,engineType,engineHour")] BoatEngine boatEngine)
        {
            if (id != boatEngine.engineID)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(boatEngine);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!BoatEngineExists(boatEngine.engineID))
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
            return View(boatEngine);
        }

        // GET: BoatEngines/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null || _context.BoatEngines == null)
            {
                return NotFound();
            }

            var boatEngine = await _context.BoatEngines
                .FirstOrDefaultAsync(m => m.engineID == id);
            if (boatEngine == null)
            {
                return NotFound();
            }

            return View(boatEngine);
        }

        // POST: BoatEngines/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            if (_context.BoatEngines == null)
            {
                return Problem("Entity set 'ApplicationDbContext.BoatEngines'  is null.");
            }
            var boatEngine = await _context.BoatEngines.FindAsync(id);
            if (boatEngine != null)
            {
                _context.BoatEngines.Remove(boatEngine);
            }
            
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool BoatEngineExists(int id)
        {
          return (_context.BoatEngines?.Any(e => e.engineID == id)).GetValueOrDefault();
        }
    }
}
