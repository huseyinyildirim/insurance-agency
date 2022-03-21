using InsuranceAgency.Data.Entities;
using Microsoft.EntityFrameworkCore;

namespace InsuranceAgency.Data
{
    public class AppDbContext : DbContext
    {
        public const string DEFAULT_SCHEMA = "InsuranceAgency";

        public AppDbContext()
        {

        }
        public AppDbContext(DbContextOptions connString) : base(connString)
        {

        }

        public DbSet<InsuranceProvider> InsuranceProviders { get; set; }
        public DbSet<Offer> Offers { get; set; }
        public DbSet<Quotation> Quotations { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<InsuranceProvider>().ToTable("InsuranceProviders", DEFAULT_SCHEMA);
            modelBuilder.Entity<Offer>().ToTable("Offers", DEFAULT_SCHEMA);
            modelBuilder.Entity<Quotation>().ToTable("Quotations", DEFAULT_SCHEMA);

            modelBuilder.Entity<Offer>().Property(x => x.Amount).HasColumnType("decimal(18,2)");

            base.OnModelCreating(modelBuilder);
        }
    }
}
