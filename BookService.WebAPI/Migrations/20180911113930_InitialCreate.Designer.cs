﻿// <auto-generated />
using System;
using BookService.WebAPI.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace BookService.WebAPI.Migrations
{
    [DbContext(typeof(BookServiceContext))]
    [Migration("20180911113930_InitialCreate")]
    partial class InitialCreate
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.1.2-rtm-30932")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("BookService.WebAPI.Models.Author", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("BirthDate");

                    b.Property<string>("FirstName");

                    b.Property<string>("LastName");

                    b.HasKey("Id");

                    b.ToTable("Author");

                    b.HasData(
                        new { Id = 1, BirthDate = new DateTime(1980, 5, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), FirstName = "James", LastName = "Sharp" },
                        new { Id = 2, BirthDate = new DateTime(1992, 3, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), FirstName = "Sophie", LastName = "Netty" },
                        new { Id = 3, BirthDate = new DateTime(1996, 8, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), FirstName = "Elisa", LastName = "Yammy" }
                    );
                });

            modelBuilder.Entity("BookService.WebAPI.Models.Book", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("AuthorId");

                    b.Property<string>("ISBN");

                    b.Property<string>("ImageUrl");

                    b.Property<int>("NumberOfPages");

                    b.Property<int?>("PublisherId");

                    b.Property<string>("Title");

                    b.HasKey("Id");

                    b.HasIndex("AuthorId");

                    b.HasIndex("PublisherId");

                    b.ToTable("Book");

                    b.HasData(
                        new { Id = 1, AuthorId = 1, ISBN = "123456789", ImageUrl = "images/book1.jpg", NumberOfPages = 420, PublisherId = 1, Title = "Learning C#" },
                        new { Id = 2, AuthorId = 2, ISBN = "45689132", ImageUrl = "images/book2.jpg", NumberOfPages = 360, PublisherId = 1, Title = "Mastering Linq" },
                        new { Id = 3, AuthorId = 1, ISBN = "15856135", ImageUrl = "images/book2.jpg", NumberOfPages = 360, PublisherId = 1, Title = "Mastering Xamarin" },
                        new { Id = 4, AuthorId = 2, ISBN = "56789564", ImageUrl = "images/book3.jpg", NumberOfPages = 360, PublisherId = 1, Title = "Exploring ASP.Net Core 2.0" },
                        new { Id = 5, AuthorId = 2, ISBN = "234546684", ImageUrl = "images/book1.jpg", NumberOfPages = 420, PublisherId = 1, Title = "Unity Game Development" },
                        new { Id = 6, AuthorId = 3, ISBN = "789456258", ImageUrl = "images/book3.jpg", NumberOfPages = 40, PublisherId = 2, Title = "Cooking is fun" },
                        new { Id = 7, AuthorId = 3, ISBN = "94521546", ImageUrl = "images/book3.jpg", NumberOfPages = 53, PublisherId = 2, Title = "Secret recipes" }
                    );
                });

            modelBuilder.Entity("BookService.WebAPI.Models.Publisher", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Country");

                    b.Property<string>("Name");

                    b.HasKey("Id");

                    b.ToTable("Publisher");

                    b.HasData(
                        new { Id = 1, Country = "UK", Name = "IT-publishers" },
                        new { Id = 2, Country = "Sweden", Name = "FoodBooks" }
                    );
                });

            modelBuilder.Entity("BookService.WebAPI.Models.Book", b =>
                {
                    b.HasOne("BookService.WebAPI.Models.Author", "Author")
                        .WithMany()
                        .HasForeignKey("AuthorId");

                    b.HasOne("BookService.WebAPI.Models.Publisher", "Publisher")
                        .WithMany()
                        .HasForeignKey("PublisherId");
                });
#pragma warning restore 612, 618
        }
    }
}
