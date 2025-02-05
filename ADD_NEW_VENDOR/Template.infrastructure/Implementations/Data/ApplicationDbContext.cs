using Microsoft.EntityFrameworkCore;
using Template.Domain.Model;

namespace Template.infrastructure.Implementations.Data
{
    /// <summary>
    /// Configures database schema and validation rules for Vendor entity properties.
    /// </summary>
    /// <remarks>
    /// Defines primary key, sets required fields, and applies length constraints 
    /// for vendor-related data attributes.
    /// </remarks>
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) { }

        public DbSet<Vendor> Vendors { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Vendor>(entity =>
            {
                entity.HasKey(e => e.Id);
                entity.Property(e => e.Id)
                .ValueGeneratedOnAdd();

                entity.Property(e => e.VendorName)
                    .IsRequired()
                    .HasMaxLength(200);

                entity.Property(e => e.Email)
                    .HasMaxLength(100);

                entity.Property(e => e.StreetAddress1)
                    .HasMaxLength(200);

                entity.Property(e => e.StreetAddress2)
                    .HasMaxLength(200);

                entity.Property(e => e.City)
                    .HasMaxLength(100);

                entity.Property(e => e.Country)
                    .HasMaxLength(100);

                entity.Property(e => e.State)
                    .HasMaxLength(100);

                entity.Property(e => e.PostalCode)
                    .HasMaxLength(20);

                entity.Property(e => e.Market)
                    .HasMaxLength(100);

                entity.Property(e => e.PhoneCode)
                    .HasMaxLength(10);

                entity.Property(e => e.Phone)
                    .HasMaxLength(20);

                entity.Property(e => e.Website)
                    .HasMaxLength(200);

                entity.Property(e => e.ContractType)
                    .HasMaxLength(50);

                entity.Property(e => e.VendorConfidence)
                    .HasMaxLength(50);

                entity.Property(e => e.ServiceType)
                    .HasMaxLength(50);


            });
        }
    }
}