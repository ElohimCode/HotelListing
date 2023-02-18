using Microsoft.EntityFrameworkCore;

namespace HotelList.Core.Domain.Entities
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<Country> Countries { get; set; }
        public DbSet<Hotel> Hotels { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Country>().ToTable("Countries");
            modelBuilder.Entity<Hotel>().ToTable("Hotels");

            // Seed to Countries
            string countriesJSON = System.IO.File.ReadAllText("countries.json");
            List<Country>? countries = System.Text.Json.JsonSerializer.Deserialize<List<Country>>(countriesJSON);

            foreach (Country country in countries)
                modelBuilder.Entity<Country>().HasData(country);

            // Seed to Hotels
            string hotelsJSON = System.IO.File.ReadAllText("hotels.json");
            List<Hotel>? hotels = System.Text.Json.JsonSerializer.Deserialize<List<Hotel>>(hotelsJSON);

            foreach (Hotel hotel in hotels)
                modelBuilder.Entity<Hotel>().HasData(hotel);
        }
    }
}
