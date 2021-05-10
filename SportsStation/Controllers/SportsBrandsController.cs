using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using SportsStation.Data;
using SportsStation.Models;
using Microsoft.AspNetCore.Authorization;

namespace SportsStation.Controllers
{
    [Authorize(Roles="power")]
    public class SportsBrandsController : Controller
    {
        private readonly ApplicationDbContext _context;

        public SportsBrandsController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: SportsBrands
        public async Task<IActionResult> Index()
        {
            return View(await _context.SportsBrands.ToListAsync());
        }

        // GET: SportsBrands/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var brand = await _context.SportsBrands
                .FirstOrDefaultAsync(m => m.SportsBrandID == id);
            if (brand == null)
            {
                return NotFound();
            }

            return View(brand);
        }

        // GET: SportsBrands/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: SportsBrands/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("SportsBrandID,SportsBrandName")] SportsBrand brand)
        {
            if (ModelState.IsValid)
            {
                _context.Add(brand);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(brand);
        }

        // GET: SportsBrands/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var sbrand = await _context.SportsBrands.FindAsync(id);
            if (sbrand == null)
            {
                return NotFound();
            }
            return View(sbrand);
        }

        // POST: SportsBrands/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("SportsBrandID,SportsBrandName")] SportsBrand sbrand)
        {
            if (id != sbrand.SportsBrandID)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(sbrand);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!SportsBrandsExists(sbrand.SportsBrandID))
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
            return View(sbrand);
        }

        // GET: SportsBrands/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var sbrand = await _context.SportsBrands
                .FirstOrDefaultAsync(m => m.SportsBrandID == id);
            if (sbrand == null)
            {
                return NotFound();
            }

            return View(sbrand);
        }

        // POST: SportsBrands/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var sbrand = await _context.SportsBrands.FindAsync(id);
            _context.SportsBrands.Remove(sbrand);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool SportsBrandsExists(int id)
        {
            return _context.SportsBrands.Any(e => e.SportsBrandID == id);
        }
    }
}
