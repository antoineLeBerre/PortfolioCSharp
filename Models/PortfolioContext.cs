using Microsoft.EntityFrameworkCore;
using PortofolioAdmin.Models.Configuration;
using PortofolioAdmin.Models.Models;

namespace PortofolioAdmin.Models
{
    public class PortfolioContext : DbContext
    {
        public DbSet<AdminLogin> AdminLogins { get; set; }
        
        public PortfolioContext(DbContextOptions options) : base(options)
        {
        }
        
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new AdminLoginConfiguration());
        }
    }
}