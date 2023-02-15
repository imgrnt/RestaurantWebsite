﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using RestaurantWebsite.Models;

#nullable disable

namespace RestaurantWebsite.Migrations
{
    [DbContext(typeof(FoodContext))]
    [Migration("20230215205245_Initial")]
    partial class Initial
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "6.0.0");

            modelBuilder.Entity("RestaurantWebsite.Models.Food", b =>
                {
                    b.Property<int>("MenuId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Name")
                        .HasColumnType("TEXT");

                    b.Property<double?>("Price")
                        .HasColumnType("REAL");

                    b.HasKey("MenuId");

                    b.ToTable("Foods");

                    b.HasData(
                        new
                        {
                            MenuId = 1,
                            Name = "Plain Pizza",
                            Price = 10.0
                        },
                        new
                        {
                            MenuId = 2,
                            Name = "Pepperoni Pizza",
                            Price = 14.99
                        },
                        new
                        {
                            MenuId = 3,
                            Name = "Pizza with Salami and Olives",
                            Price = 15.99
                        },
                        new
                        {
                            MenuId = 4,
                            Name = "Quattro Pizza Formaggi",
                            Price = 14.99
                        },
                        new
                        {
                            MenuId = 5,
                            Name = "Margherita Pizza",
                            Price = 10.99
                        },
                        new
                        {
                            MenuId = 6,
                            Name = "Pizza with Minced Meat",
                            Price = 15.99
                        },
                        new
                        {
                            MenuId = 7,
                            Name = "Hot Salami Pizza",
                            Price = 14.99
                        },
                        new
                        {
                            MenuId = 8,
                            Name = "Pizza with Grilled Meat",
                            Price = 16.989999999999998
                        });
                });

            modelBuilder.Entity("RestaurantWebsite.Models.Reservation", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Fname")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Lname")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Note")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<int?>("People")
                        .IsRequired()
                        .HasColumnType("INTEGER");

                    b.Property<string>("PhoneNumber")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<DateTime?>("ReserveDate")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("ReserveTime")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("Reservations");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Email = "AnaMarie@gmail.com",
                            Fname = "Ana",
                            Lname = "Marie",
                            Note = "n/a",
                            People = 5,
                            PhoneNumber = "215-123-4567",
                            ReserveDate = new DateTime(2020, 1, 22, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            ReserveTime = "6:30 PM"
                        });
                });
#pragma warning restore 612, 618
        }
    }
}