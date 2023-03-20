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
    public class MotorHomesController : Controller
    {
        private readonly ApplicationDbContext _context;

        public MotorHomesController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: MotorHomes
        public async Task<IActionResult> Index()
        {
              return _context.MotorHomes != null ? 
                          View(await _context.MotorHomes.ToListAsync()) :
                          Problem("Entity set 'ApplicationDbContext.MotorHomes'  is null.");
        }

        // GET: MotorHomes/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null || _context.MotorHomes == null)
            {
                return NotFound();
            }

            var motorHomes = await _context.MotorHomes
                .FirstOrDefaultAsync(m => m.vehicleID == id);
            if (motorHomes == null)
            {
                return NotFound();
            }

            return View(motorHomes);
        }

        // GET: MotorHomes/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: MotorHomes/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("slideOuts,sleeps,fuelType,rvClass,length,vehicleID,vehicleMake,vehicleModel,year,miles,mpg,condition,price,description,ImageUpload")] MotorHomes motorHomes)
        {
            if (ModelState.IsValid)
            {
                _context.Add(motorHomes);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(motorHomes);
        }

        // GET: MotorHomes/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null || _context.MotorHomes == null)
            {
                return NotFound();
            }

            var motorHomes = await _context.MotorHomes.FindAsync(id);
            if (motorHomes == null)
            {
                return NotFound();
            }
            return View(motorHomes);
        }

        // POST: MotorHomes/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("slideOuts,sleeps,fuelType,rvClass,length,vehicleID,vehicleMake,vehicleModel,year,miles,mpg,condition,price,description,ImageUpload")] MotorHomes motorHomes)
        {
            if (id != motorHomes.vehicleID)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(motorHomes);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!MotorHomesExists(motorHomes.vehicleID))
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
            return View(motorHomes);
        }

        // GET: MotorHomes/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null || _context.MotorHomes == null)
            {
                return NotFound();
            }

            var motorHomes = await _context.MotorHomes
                .FirstOrDefaultAsync(m => m.vehicleID == id);
            if (motorHomes == null)
            {
                return NotFound();
            }

            return View(motorHomes);
        }

        // POST: MotorHomes/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            if (_context.MotorHomes == null)
            {
                return Problem("Entity set 'ApplicationDbContext.MotorHomes'  is null.");
            }
            var motorHomes = await _context.MotorHomes.FindAsync(id);
            if (motorHomes != null)
            {
                _context.MotorHomes.Remove(motorHomes);
            }
            
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool MotorHomesExists(int id)
        {
          return (_context.MotorHomes?.Any(e => e.vehicleID == id)).GetValueOrDefault();
        }
    }
}
