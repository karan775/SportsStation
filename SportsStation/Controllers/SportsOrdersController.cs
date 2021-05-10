using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using SportsStation.Data;
using SportsStation.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Authorization;

namespace SportsStation.Controllers
{
    public class SportsOrdersController : Controller
    {
        private readonly ApplicationDbContext _context;
        private readonly UserManager<IdentityUser> _userManager;

        public SportsOrdersController(ApplicationDbContext context, UserManager<IdentityUser> userManager)
        {
            _context = context;
            _userManager = userManager;
        }

        [Authorize(Roles = "power")]
        // GET: SportsOrders
        public async Task<IActionResult> Index()
        {
            return View(await _context.SportsOrders.ToListAsync());
        }

        [Authorize(Roles = "power")]
        // GET: SportsOrders/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var sportsOrder = await _context.SportsOrders
                .FirstOrDefaultAsync(m => m.OrderID == id);
            if (sportsOrder == null)
            {
                return NotFound();
            }

            return View(sportsOrder);
        }

        [Authorize]
        // GET: SportsOrders/Create
        public IActionResult Create()
        {
            ViewData["SportsID"] = new SelectList(_context.SportsMaterials, "SportsID", "ProductName");
            return View();
        }

        // POST: SportsOrders/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("OrderID,Detail,Quantity,SportsID")] SportsOrder sportsOrder)
        {
            ModelState.Remove("Price");
            ModelState.Remove("Total");
            ModelState.Remove("UserID");
            ModelState.Remove("OrderDate");

            if (ModelState.IsValid)
            {

                var sportsMaterial = await _context.SportsMaterials
                    .FirstOrDefaultAsync(m => m.SportsID == sportsOrder.SportsID);
                sportsOrder.Price = sportsMaterial.Price;
                sportsOrder.Total = sportsOrder.Price * sportsOrder.Quantity;
                sportsOrder.UserID = _userManager.GetUserName(this.User);
                sportsOrder.OrderDate = DateTime.Now;
                _context.Add(sportsOrder);
                await _context.SaveChangesAsync();
                return RedirectToAction("Success", "Home");
            }
            ViewData["SportsID"] = new SelectList(_context.SportsMaterials, "SportsID", "ProductName", sportsOrder.SportsID);
            return View(sportsOrder);
        }


        [Authorize(Roles = "power")]
        // GET: SportsOrders/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var sportsOrder = await _context.SportsOrders
                .FirstOrDefaultAsync(m => m.OrderID == id);
            if (sportsOrder == null)
            {
                return NotFound();
            }

            return View(sportsOrder);
        }

        // POST: SportsOrders/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var sportsOrder = await _context.SportsOrders.FindAsync(id);
            _context.SportsOrders.Remove(sportsOrder);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool SportsOrderExists(int id)
        {
            return _context.SportsOrders.Any(e => e.OrderID == id);
        }
    }
}
