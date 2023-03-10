// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Mission06_brd48.Models;

namespace Mission06_brd48.Migrations
{
    [DbContext(typeof(MovieFormContext))]
    [Migration("20230214000222_Initial")]
    partial class Initial
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.32");

            modelBuilder.Entity("Mission06_brd48.Models.FormResponse", b =>
                {
                    b.Property<int>("MovieId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Category")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Director")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<bool>("Edited")
                        .HasColumnType("INTEGER");

                    b.Property<string>("LentTo")
                        .HasColumnType("TEXT");

                    b.Property<string>("MovieTitle")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Notes")
                        .HasColumnType("TEXT");

                    b.Property<string>("Rating")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<int>("Year")
                        .HasColumnType("INTEGER");

                    b.HasKey("MovieId");

                    b.ToTable("responses");

                    b.HasData(
                        new
                        {
                            MovieId = 1,
                            Category = "Fantasy",
                            Director = "Mike Newell",
                            Edited = false,
                            LentTo = "",
                            MovieTitle = "Harry Potter and the Goblet of Fire",
                            Notes = "",
                            Rating = "PG-13",
                            Year = 2005
                        },
                        new
                        {
                            MovieId = 2,
                            Category = "Sci-fi",
                            Director = "Christopher Nolan",
                            Edited = false,
                            LentTo = "my friend george",
                            MovieTitle = "Interstellar",
                            Notes = "good movie",
                            Rating = "PG-13",
                            Year = 2014
                        },
                        new
                        {
                            MovieId = 3,
                            Category = "Comedy",
                            Director = "Akiva Schaffer",
                            Edited = false,
                            LentTo = "",
                            MovieTitle = "Hot Rod",
                            Notes = "",
                            Rating = "PG-13",
                            Year = 2007
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
