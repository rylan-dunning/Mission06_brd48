using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Mission06_brd48.Models
{
    public class MovieFormContext : DbContext
    {
        //Constructor
        public MovieFormContext(DbContextOptions<MovieFormContext> options) : base(options)
        {
            //leave blank for now
        }

        public DbSet<FormResponse> responses { get; set; }

        protected override void OnModelCreating(ModelBuilder mb)
        {
            mb.Entity<FormResponse>().HasData(

                new FormResponse
                {
                    MovieId = 1,
                    MovieTitle = "Harry Potter and the Goblet of Fire",
                    Category = "Fantasy",
                    Year = 2005,
                    Director = "Mike Newell",
                    Rating = "PG-13",
                    Edited = false,
                    LentTo = "",
                    Notes = ""
                },
                new FormResponse
                {
                    MovieId = 2,
                    MovieTitle = "Interstellar",
                    Category = "Sci-fi",
                    Year = 2014,
                    Director = "Christopher Nolan",
                    Rating = "PG-13",
                    Edited = false,
                    LentTo = "my friend george",
                    Notes = "good movie"
                },
                new FormResponse
                {
                    MovieId = 3,
                    MovieTitle = "Hot Rod",
                    Category = "Comedy",
                    Year = 2007,
                    Director = "Akiva Schaffer",
                    Rating = "PG-13",
                    Edited = false,
                    LentTo = "",
                    Notes = ""
                }
            );
        }
    }
}
