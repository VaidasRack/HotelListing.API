using Microsoft.EntityFrameworkCore;

namespace HotelListing.API.Data
{
    public class HotelListingDbContext : DbContext
    {
        public HotelListingDbContext(DbContextOptions options) : base(options)
        {

        }

        public DbSet<Hotel> Hotels { get; set; }
        public DbSet<Country> Countries { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Country>().HasData(
                new Country
                {
                    Id = 1,
                    Name = "Lithuania",
                    ShortName = "LT"
                },
                new Country
                {
                    Id = 2,
                    Name = "Egypt",
                    ShortName = "EG"
                },
                new Country
                {
                    Id = 3,
                    Name = "Ukraine",
                    ShortName = "UA"
                }
            );

            modelBuilder.Entity<Hotel>().HasData(
                new Hotel
                {
                    Id = 1,
                    Name = "Vilnius Hotel",
                    Address = "Vilnius, LT",
                    CountryId = 1,
                    Rating = 4.6
                },
                new Hotel
                {
                    Id = 2,
                    Name = "Hurghada Hotel",
                    Address = "Hurghada, EG",
                    CountryId = 2,
                    Rating = 4.7
                },
                new Hotel
                {
                    Id = 3,
                    Name = "Kyiv Hotel",
                    Address = "Kyiv, UA",
                    CountryId = 3,
                    Rating = 4.8
                }
            );
        }
    }
}
