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
    [Authorize(Roles = "power")]
    public class SportsCategoriesController : Controller
    {
        private readonly ApplicationDbContext _context;

        public SportsCategoriesController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: SportsCategories
        public async Task<IActionResult> Index()
        {
            return View(await _context.SportsCategories.ToListAsync());
        }

        // GET: SportsCategories/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var spCategory = await _context.SportsCategories
                .FirstOrDefaultAsync(m => m.SportsCategoryID == id);
            if (spCategory == null)
            {
                return NotFound();
            }

            return View(spCategory);
        }

        // GET: SportsCategories/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: SportsCategories/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("SportsCategoryID,SportsCategoryName")] SportsCategory spCategory)
        {
            if (ModelState.IsValid)
            {
                _context.Add(spCategory);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(spCategory);
        }

        // GET: SportsCategories/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var spCategory = await _context.SportsCategories.FindAsync(id);
            if (spCategory == null)
            {
                return NotFound();
            }
            return View(spCategory);
        }

        // POST: SportsCategories/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("SportsCategoryID,SportsCategoryName")] SportsCategory spCategory)
        {
            if (id != spCategory.SportsCategoryID)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(spCategory);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!SportsCategoriesExists(spCategory.SportsCategoryID))
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
            return View(spCategory);
        }

        // GET: SportsCategories/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var spCategory = await _context.SportsCategories
                .FirstOrDefaultAsync(m => m.SportsCategoryID == id);
            if (spCategory == null)
            {
                return NotFound();
            }

            return View(spCategory);
        }

        // POST: SportsCategories/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var spCategory = await _context.SportsCategories.FindAsync(id);
            _context.SportsCategories.Remove(spCategory);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool SportsCategoriesExists(int id)
        {
            return _context.SportsCategories.Any(e => e.SportsCategoryID == id);
        }
    }
}
