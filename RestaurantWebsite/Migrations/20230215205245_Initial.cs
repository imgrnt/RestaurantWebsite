using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace RestaurantWebsite.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Foods",
                columns: table => new
                {
                    MenuId = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Name = table.Column<string>(type: "TEXT", nullable: true),
                    Price = table.Column<double>(type: "REAL", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Foods", x => x.MenuId);
                });

            migrationBuilder.CreateTable(
                name: "Reservations",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Fname = table.Column<string>(type: "TEXT", nullable: false),
                    Lname = table.Column<string>(type: "TEXT", nullable: false),
                    Email = table.Column<string>(type: "TEXT", nullable: false),
                    PhoneNumber = table.Column<string>(type: "TEXT", nullable: false),
                    ReserveDate = table.Column<DateTime>(type: "TEXT", nullable: false),
                    ReserveTime = table.Column<string>(type: "TEXT", nullable: false),
                    People = table.Column<int>(type: "INTEGER", nullable: false),
                    Note = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Reservations", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Foods",
                columns: new[] { "MenuId", "Name", "Price" },
                values: new object[] { 1, "Plain Pizza", 10.0 });

            migrationBuilder.InsertData(
                table: "Foods",
                columns: new[] { "MenuId", "Name", "Price" },
                values: new object[] { 2, "Pepperoni Pizza", 14.99 });

            migrationBuilder.InsertData(
                table: "Foods",
                columns: new[] { "MenuId", "Name", "Price" },
                values: new object[] { 3, "Pizza with Salami and Olives", 15.99 });

            migrationBuilder.InsertData(
                table: "Foods",
                columns: new[] { "MenuId", "Name", "Price" },
                values: new object[] { 4, "Quattro Pizza Formaggi", 14.99 });

            migrationBuilder.InsertData(
                table: "Foods",
                columns: new[] { "MenuId", "Name", "Price" },
                values: new object[] { 5, "Margherita Pizza", 10.99 });

            migrationBuilder.InsertData(
                table: "Foods",
                columns: new[] { "MenuId", "Name", "Price" },
                values: new object[] { 6, "Pizza with Minced Meat", 15.99 });

            migrationBuilder.InsertData(
                table: "Foods",
                columns: new[] { "MenuId", "Name", "Price" },
                values: new object[] { 7, "Hot Salami Pizza", 14.99 });

            migrationBuilder.InsertData(
                table: "Foods",
                columns: new[] { "MenuId", "Name", "Price" },
                values: new object[] { 8, "Pizza with Grilled Meat", 16.989999999999998 });

            migrationBuilder.InsertData(
                table: "Reservations",
                columns: new[] { "Id", "Email", "Fname", "Lname", "Note", "People", "PhoneNumber", "ReserveDate", "ReserveTime" },
                values: new object[] { 1, "AnaMarie@gmail.com", "Ana", "Marie", "n/a", 5, "215-123-4567", new DateTime(2020, 1, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), "6:30 PM" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Foods");

            migrationBuilder.DropTable(
                name: "Reservations");
        }
    }
}
