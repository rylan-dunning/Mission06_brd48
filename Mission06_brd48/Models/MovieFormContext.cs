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
        public DbSet<Category> Categories { get; set; }

        //Seed data
        protected override void OnModelCreating(ModelBuilder mb)
        {
            mb.Entity<Category>().HasData(
                new Category { CategoryId = 1, CategoryName = "Fantasy"},
                new Category { CategoryId = 2, CategoryName = "Science Fiction" },
                new Category { CategoryId = 3, CategoryName = "Comedy" },
                new Category { CategoryId = 4, CategoryName = "Romance" },
                new Category { CategoryId = 5, CategoryName = "Action" },
                new Category { CategoryId = 6, CategoryName = "Drama" },
                new Category { CategoryId = 7, CategoryName = "Animated" },
                new Category { CategoryId = 8, CategoryName = "Thriller" },
                new Category { CategoryId = 9, CategoryName = "Horror" },
                new Category { CategoryId = 10, CategoryName = "History" },
                new Category { CategoryId = 11, CategoryName = "Documentary" },
                new Category { CategoryId = 12, CategoryName = "Other" }
            );

            mb.Entity<FormResponse>().HasData(

                new FormResponse
                {
                    MovieId = 1,
                    MovieTitle = "Harry Potter and the Goblet of Fire",
                    CategoryId = 1, //"Fantasy",
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
                    CategoryId = 2, //"Sci-fi",
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
                    CategoryId = 3, //"Comedy",
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
