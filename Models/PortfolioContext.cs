using Microsoft.EntityFrameworkCore;

namespace Portofolio.Models
{
    public class PortfolioContext : DbContext
    {
        public PortfolioContext(DbContextOptions options) : base(options)
        {
        }
        
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //modelBuilder.ApplyConfiguration(new UserConfigurations());
        }
    }
}