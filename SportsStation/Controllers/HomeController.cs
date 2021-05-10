using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using SportsStation.Models;
using SportsStation.Data;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Authorization;

namespace SportsStation.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly ApplicationDbContext _context;
        private readonly UserManager<IdentityUser> _userManager;

        public HomeController(ApplicationDbContext context, UserManager<IdentityUser> userManager, ILogger<HomeController> logger)
        {
            _logger = logger;
            _context = context;
            _userManager = userManager;
        }

        public async Task<IActionResult> Index()
        {
            return View(await _context.SportsCategories.OrderBy(x => Guid.NewGuid()).ToListAsync());
        }

        public async Task<IActionResult> ViewAllSportsBrands()
        {
            return View(await _context.SportsBrands.OrderBy(x => Guid.NewGuid()).ToListAsync());
        }

        public async Task<IActionResult> ViewAllSportsCategories()
        {
            return View(await _context.SportsCategories.OrderBy(x => Guid.NewGuid()).ToListAsync());
        }

        public async Task<IActionResult> ViewSportsMaterialBySportsCategory(int? id)
        {
            var applicationDbContext = _context.SportsMaterials
            .Include(b => b.SportsCategorySportsMaterial).Include(b => b.SportsCategorySportsMaterial).Where(m => m.SportsCategoryID == id);
            return View(await applicationDbContext.ToListAsync());
        }

        public async Task<IActionResult> ViewSportsMaterialByBrand(int? id)
        {
            var applicationDbContext = _context.SportsMaterials
            .Include(b => b.SportsCategorySportsMaterial).Include(b => b.SportsCategorySportsMaterial).Where(m => m.SportsBrandID == id);
            return View(await applicationDbContext.ToListAsync());
        }

        [Authorize]
        public async Task<IActionResult> UserOrderHistory()
        {
            var applicationDbContext = _context.SportsOrders
            .Include(b => b.SportsMaterial).Where(m => m.UserID == _userManager.GetUserName(this.User));
            return View(await applicationDbContext.ToListAsync());
        }

        public IActionResult Success()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
