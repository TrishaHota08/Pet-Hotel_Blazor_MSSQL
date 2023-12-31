﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using PetHotelData;

#nullable disable

namespace PetHotelData.Migrations
{
    [DbContext(typeof(PetHotelContext))]
    [Migration("20230623164859_adddatabaseanddata")]
    partial class adddatabaseanddata
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.19")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("PetHotelDomain.Cats", b =>
                {
                    b.Property<int>("CatsId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("CatsId"), 1L, 1);

                    b.Property<DateTime>("ArrivalDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("CageLocation")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CatName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("EstimatedDepartureDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("ownerEmail")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ownerName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ownerPhone")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("CatsId");

                    b.ToTable("Cats");

                    b.HasData(
                        new
                        {
                            CatsId = 1,
                            ArrivalDate = new DateTime(2023, 5, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            CageLocation = "1A",
                            CatName = "Lucy",
                            Description = "black cat",
                            EstimatedDepartureDate = new DateTime(2023, 5, 11, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            ownerEmail = "sarah123@gmail.com",
                            ownerName = "Sarah",
                            ownerPhone = "8956789"
                        },
                        new
                        {
                            CatsId = 2,
                            ArrivalDate = new DateTime(2023, 4, 30, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            CageLocation = "1D",
                            CatName = "Winny",
                            Description = "fluffy cat",
                            EstimatedDepartureDate = new DateTime(2023, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            ownerEmail = "william567@gmail.com",
                            ownerName = "Wiiliam",
                            ownerPhone = "67658978"
                        },
                        new
                        {
                            CatsId = 3,
                            ArrivalDate = new DateTime(2023, 5, 30, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            CageLocation = "2A",
                            CatName = "Edee",
                            Description = "white cat with brown patches",
                            EstimatedDepartureDate = new DateTime(2023, 6, 30, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            ownerEmail = "alwex@gmail.com",
                            ownerName = "Alex",
                            ownerPhone = "7677868"
                        },
                        new
                        {
                            CatsId = 4,
                            ArrivalDate = new DateTime(2023, 5, 3, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            CageLocation = "2C",
                            CatName = "Tuffy",
                            Description = "thin cat",
                            EstimatedDepartureDate = new DateTime(2023, 8, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            ownerEmail = "alwex@gmail.com",
                            ownerName = "Alex",
                            ownerPhone = "7677868"
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
