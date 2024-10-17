using Microsoft.EntityFrameworkCore;
using MyTrailer.Domain.Entities;
using MyTrailer.Domain.ValueObjects;

namespace MyTrailer.Infrastructure.Persistence
{
    public class MyTrailerDbContext : DbContext
    {
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Location> Locations { get; set; }
        public DbSet<PartnerCompany> partnerCompanies { get; set; }
        public DbSet<Rental> Rentals { get; set; }
        public DbSet<Trailer> Trailers { get; set; }

        public MyTrailerDbContext(DbContextOptions<MyTrailerDbContext> options)
            : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // Configure Address as an owned type of Customer
            modelBuilder.Entity<Customer>()
                .OwnsOne(c => c.Address, a =>
                {
                    a.Property(p => p.Street).HasColumnName("Street");
                    a.Property(p => p.City).HasColumnName("City");
                    a.Property(p => p.PostalCode).HasColumnName("PostalCode");
                });

            base.OnModelCreating(modelBuilder);
        }
    }
}



