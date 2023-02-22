﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Mission06_brd48.Models;

namespace Mission06_brd48.Migrations
{
    [DbContext(typeof(MovieFormContext))]
    [Migration("20230221231811_Initial")]
    partial class Initial
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.32");

            modelBuilder.Entity("Mission06_brd48.Models.Category", b =>
                {
                    b.Property<int>("CategoryId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("CategoryName")
                        .HasColumnType("TEXT");

                    b.HasKey("CategoryId");

                    b.ToTable("Categories");

                    b.HasData(
                        new
                        {
                            CategoryId = 1,
                            CategoryName = "Fantasy"
                        },
                        new
                        {
                            CategoryId = 2,
                            CategoryName = "Science Fiction"
                        },
                        new
                        {
                            CategoryId = 3,
                            CategoryName = "Comedy"
                        },
                        new
                        {
                            CategoryId = 4,
                            CategoryName = "Romance"
                        },
                        new
                        {
                            CategoryId = 5,
                            CategoryName = "Action"
                        },
                        new
                        {
                            CategoryId = 6,
                            CategoryName = "Drama"
                        },
                        new
                        {
                            CategoryId = 7,
                            CategoryName = "Animated"
                        },
                        new
                        {
                            CategoryId = 8,
                            CategoryName = "Thriller"
                        },
                        new
                        {
                            CategoryId = 9,
                            CategoryName = "Horror"
                        },
                        new
                        {
                            CategoryId = 10,
                            CategoryName = "History"
                        },
                        new
                        {
                            CategoryId = 11,
                            CategoryName = "Documentary"
                        },
                        new
                        {
                            CategoryId = 12,
                            CategoryName = "Other"
                        });
                });

            modelBuilder.Entity("Mission06_brd48.Models.FormResponse", b =>
                {
                    b.Property<int>("MovieId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int>("CategoryId")
                        .HasColumnType("INTEGER");

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
                        .HasColumnType("TEXT")
                        .HasMaxLength(25);

                    b.Property<string>("Rating")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<int>("Year")
                        .HasColumnType("INTEGER");

                    b.HasKey("MovieId");

                    b.HasIndex("CategoryId");

                    b.ToTable("responses");

                    b.HasData(
                        new
                        {
                            MovieId = 1,
                            CategoryId = 1,
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
                            CategoryId = 2,
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
                            CategoryId = 3,
                            Director = "Akiva Schaffer",
                            Edited = false,
                            LentTo = "",
                            MovieTitle = "Hot Rod",
                            Notes = "",
                            Rating = "PG-13",
                            Year = 2007
                        });
                });

            modelBuilder.Entity("Mission06_brd48.Models.FormResponse", b =>
                {
                    b.HasOne("Mission06_brd48.Models.Category", "Category")
                        .WithMany()
                        .HasForeignKey("CategoryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
