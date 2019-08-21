using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using PortofolioAdmin.Models.Models;

namespace PortofolioAdmin.Models.Configuration
{
    public class AdminLoginConfiguration : IEntityTypeConfiguration<AdminLogin>
    { 
        public void Configure(EntityTypeBuilder<AdminLogin> builder)
        {
            builder.ToTable("p_AdminLogin");
            builder.Property(p => p.Id)
                .ValueGeneratedOnAdd();
            
            builder.Property(p => p.Login)
                .HasMaxLength(14)
                .IsRequired();
            
            builder.Property(p => p.Password)
                .HasMaxLength(128)
                .IsRequired();
        }
    }
}