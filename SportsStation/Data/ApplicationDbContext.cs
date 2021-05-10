using SportsStation.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SportsStation.Data
{
    public class ApplicationDbContext:IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        public DbSet<SportsBrand> SportsBrands { get; set; }
        public DbSet<SportsCategory> SportsCategories { get; set; }
        public DbSet<SportsMaterial> SportsMaterials { get; set; }
        public DbSet<SportsOrder> SportsOrders { get; set; }
    }
}
