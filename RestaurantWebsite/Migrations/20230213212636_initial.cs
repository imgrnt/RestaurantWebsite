using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace RestaurantWebsite.Migrations
{
    public partial class initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Foods",
                columns: table => new
                {
                    MenuId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Price = table.Column<double>(type: "float", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Foods", x => x.MenuId);
                });

            migrationBuilder.CreateTable(
                name: "Reservations",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Fname = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Lname = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ReserveDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ReserveTime = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    People = table.Column<int>(type: "int", nullable: false),
                    Note = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Reservations", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Foods",
                columns: new[] { "MenuId", "Name", "Price" },
                values: new object[,]
                {
                    { 1, "Plain Pizza", 10.0 },
                    { 2, "Neopolitan Pizza", 13.449999999999999 },
                    { 3, "White Pizza", 11.0 },
                    { 4, "Philly Pizza", 14.449999999999999 },
                    { 5, "House Special Pizza", 15.0 },
                    { 6, "Meat Lovers Pizza", 13.449999999999999 }
                });

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
