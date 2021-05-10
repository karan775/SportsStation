using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using SportsStation.Data;
using SportsStation.Models;
using Microsoft.AspNetCore.Hosting;
using System.IO;
using Microsoft.AspNetCore.Authorization;

namespace SportsStation.Controllers
{
    [Authorize(Roles = "power")]
    public class SportsMaterialsController : Controller
    {
        private readonly ApplicationDbContext _context;
        private readonly IWebHostEnvironment _environment;

        public SportsMaterialsController(ApplicationDbContext context, IWebHostEnvironment env)
        {
            _context = context;
            _environment = env;
        }

        // GET: SportsMaterials
        public async Task<IActionResult> Index()
        {
            var applicationDbContext = _context.SportsMaterials.Include(f => f.SportsCategorySportsMaterial).Include(f => f.SportsBrand);
            return View(await applicationDbContext.ToListAsync());
        }

        // GET: SportsMaterials/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var sportsMaterial = await _context.SportsMaterials
                .Include(f => f.SportsCategorySportsMaterial)
                .Include(f => f.SportsBrand)
                .FirstOrDefaultAsync(m => m.SportsID == id);
            if (sportsMaterial == null)
            {
                return NotFound();
            }

            return View(sportsMaterial);
        }

        // GET: SportsMaterials/Create
        public IActionResult Create()
        {
            ViewData["SportsCategoryID"] = new SelectList(_context.SportsCategories, "SportsCategoryID", "SportsCategoryName");
            ViewData["SportsBrandID"] = new SelectList(_context.SportsBrands, "SportsBrandID", "SportsBrandName");
            return View();
        }

        // POST: SportsMaterials/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("SportsID,ProductName,Detail,File,Price,SportsBrandID,SportsCategoryID")] SportsMaterial spMaterial)
        {
            using (var memoryStream = new MemoryStream())
            {
                await spMaterial.File.FormFile.CopyToAsync(memoryStream);

                string photoname = spMaterial.File.FormFile.FileName;
                spMaterial.Extension = Path.GetExtension(photoname);
                if (!".jpg.jpeg.png.gif.bmp".Contains(spMaterial.Extension.ToLower()))
                {
                    ModelState.AddModelError("File.FormFile", "Invalid Format of Image Given.");
                }
                else
                {
                    ModelState.Remove("Extension");
                }
            }
            if (ModelState.IsValid)
            {
                _context.Add(spMaterial);
                await _context.SaveChangesAsync();
                var uploadsRootFolder = Path.Combine(_environment.WebRootPath, "SportsStationPhotos");
                if (!Directory.Exists(uploadsRootFolder))
                {
                    Directory.CreateDirectory(uploadsRootFolder);
                }
                string filename = spMaterial.SportsID + spMaterial.Extension;
                var filePath = Path.Combine(uploadsRootFolder, filename);
                using (var fileStream = new FileStream(filePath, FileMode.Create))
                {
                    await spMaterial.File.FormFile.CopyToAsync(fileStream).ConfigureAwait(false);
                }
                return RedirectToAction(nameof(Index));
            }
            ViewData["SportsCategoryID"] = new SelectList(_context.SportsCategories, "SportsCategoryID", "SportsCategoryName", spMaterial.SportsCategoryID);
            ViewData["SportsBrandID"] = new SelectList(_context.SportsBrands, "SportsBrandID", "SportsBrandName", spMaterial.SportsBrandID);
            return View(spMaterial);
        }

        // GET: SportsMaterials/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var sportsMaterial = await _context.SportsMaterials.FindAsync(id);
            if (sportsMaterial == null)
            {
                return NotFound();
            }
            ViewData["SportsCategoryID"] = new SelectList(_context.SportsCategories, "SportsCategoryID", "SportsCategoryName", sportsMaterial.SportsCategoryID);
            ViewData["SportsBrandID"] = new SelectList(_context.SportsBrands, "SportsBrandID", "SportsBrandName", sportsMaterial.SportsBrandID);
            return View(sportsMaterial);
        }

        // POST: SportsMaterials/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("SportsID,ProductName,Detail,Extension,Price,SportsBrandID,SportsCategoryID")] SportsMaterial sportsMaterial)
        {
            if (id != sportsMaterial.SportsID)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(sportsMaterial);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!SportsMaterialExists(sportsMaterial.SportsID))
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
            ViewData["SportsCategoryID"] = new SelectList(_context.SportsCategories, "SportsCategoryID", "SportsCategoryName", sportsMaterial.SportsCategoryID);
            ViewData["SportsBrandID"] = new SelectList(_context.SportsBrands, "SportsBrandID", "SportsBrandName", sportsMaterial.SportsBrandID);
            return View(sportsMaterial);
        }

        // GET: SportsMaterials/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var sportsMaterial = await _context.SportsMaterials
                .Include(f => f.SportsCategorySportsMaterial)
                .Include(f => f.SportsBrand)
                .FirstOrDefaultAsync(m => m.SportsID == id);
            if (sportsMaterial == null)
            {
                return NotFound();
            }

            return View(sportsMaterial);
        }

        // POST: SportsMaterials/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var sportsMaterial = await _context.SportsMaterials.FindAsync(id);
            _context.SportsMaterials.Remove(sportsMaterial);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool SportsMaterialExists(int id)
        {
            return _context.SportsMaterials.Any(e => e.SportsID == id);
        }
    }
}
