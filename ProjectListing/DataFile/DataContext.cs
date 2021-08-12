using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjectListing.DataFile
{
    // here we inherit from DbContext
    public class DataContext : DbContext
    {
        // define our constructor
        public DataContext(DbContextOptions options) : base(options)
        {
            
        }

        // get a data type in C# is Country and give the property a name, database will use table Countries 
        public DbSet<Country> Countries { get; set; }

        // get a data type in C# is Hotel and give the property a name, database will use table Hotels 
        public DbSet<Hotel> Hotels { get; set; }

        // we get to the database in a a connection string that will define where to look and what to look for in .json file

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.Entity<Country>().HasData(
                new Country
                {
                    Id = 1,
                    Name = "Belize",
                    Continent = "North America",
                    Code = "BZ"

                },

                new Country
                {
                    Id = 2,
                    Name = "Australia",
                    Continent = "Oceania",
                    Code = "AU"
                },

                new Country
                {
                    Id = 3,
                    Name = "Spain",
                    Continent = "Europe",
                    Code = "ES"
                },

                new Country
                {
                    Id = 4,
                    Name = "Japan",
                    Continent = "Asia",
                    Code = "JP"
                }

            );


            builder.Entity<Hotel>().HasData(
                new Hotel
                {
                    Id = 1,
                    CountryId = 1,
                    Name = "Spring Mansion Hotel",
                    Rating = 4.6,
                    Address = "383 Langosh Creek Toledo, Belize"

                },

                new Hotel
                {
                    Id = 2,
                    CountryId = 2,
                    Name = "Majestic Star Resort & Spa",
                    Rating = 5,
                    Address = "49409 Weimann Harbors, Australia"
                },

                new Hotel
                {
                    Id = 3,
                    CountryId = 3,
                    Name = "Parallel Season Resort",
                    Rating = 4.8,
                    Address = "39452 Hintz Stravenue, Spain"
                },

                new Hotel
                {
                    Id = 4,
                    CountryId = 4,
                    Name = "Antique Mountain Motel",
                    Rating = 3.8,
                    Address = "1428 Hills Village, Japan"
                }

            );
        }
    }
}
