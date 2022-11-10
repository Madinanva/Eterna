using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication2.Models;

namespace WebApplication2.DAL
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base (options)
        {

        }

        public DbSet<Setting> Settings { get; set; }
        public DbSet<Service> Services { get; set; }
        public DbSet<Portfolio> Portfolios { get; set; }
        public DbSet<PortfolioImages> PortfolioImages { get; set; }
        public DbSet<IndexSlider> IndexSliders { get; set; }
        public DbSet<Blog> Blogs { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Pricing> Pricings { get; set; }
        public DbSet<PricingServices> PricingServices { get; set; }
    }
}
