using CarApi.Data.Config;
using CarApi.Models;
using Microsoft.EntityFrameworkCore;

namespace CarApi.Data
{
    public class AppDbContext : DbContext
    {
        private readonly CountryConfiguration countryConfiguration;
        private readonly BrandConfiguration brandConfiguration;
        private readonly CarConfiguration carConfiguration;
        public AppDbContext(DbContextOptions<AppDbContext> options,
            CountryConfiguration _countryConfiguration,
            BrandConfiguration _brandConfiguration,
            CarConfiguration _carConfiguration) : base(options) {

            countryConfiguration = _countryConfiguration;
            brandConfiguration = _brandConfiguration;
            carConfiguration = _carConfiguration;
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder) {
            
            base.OnModelCreating(modelBuilder);
            //modelBuilder.ApplyConfiguration(countryConfiguration);
            countryConfiguration.Configure(modelBuilder.Entity<Country>());
            brandConfiguration.Configure(modelBuilder.Entity<Brand>());
            carConfiguration.Configure(modelBuilder.Entity<Car>());
        }

        

        public DbSet<Appointment> Appointments { get; set; }
        public DbSet<Brand> Brands { get; set; }
        public DbSet<Car> Cars { get; set; }
        public DbSet<Country> Countries { get; set; }
        public DbSet<OrderDetail> OrderDetails { get; set; }
        public DbSet<OrderItem> OrderItems { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<UserAddress> UserAddresses { get; set; }
    }
}
