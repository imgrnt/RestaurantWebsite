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
                    FoodId = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Name = table.Column<string>(type: "TEXT", nullable: false),
                    Price = table.Column<decimal>(type: "TEXT", nullable: false),
                    Description = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Foods", x => x.FoodId);
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
                columns: new[] { "FoodId", "Description", "Name", "Price" },
                values: new object[] { 1, "Homemade pizza sauce, Mozzarella cheese, Parmesan cheese", "Plain Pizza", 10m });

            migrationBuilder.InsertData(
                table: "Foods",
                columns: new[] { "FoodId", "Description", "Name", "Price" },
                values: new object[] { 2, "Pepperoni, Tomatoes, Paprika, Chili, Mozzarella, Parmesan", "Pepperoni Pizza", 14.99m });

            migrationBuilder.InsertData(
                table: "Foods",
                columns: new[] { "FoodId", "Description", "Name", "Price" },
                values: new object[] { 3, "Salami, Olives, Bell pepper, Mushrooms, Mozzarella, Parmesan", "Pizza with Salami and Olives", 15.99m });

            migrationBuilder.InsertData(
                table: "Foods",
                columns: new[] { "FoodId", "Description", "Name", "Price" },
                values: new object[] { 4, "Broccoli, Mushrooms, Bell pepper, Corn, Onion, Mozzarella, Parmesan", "Veggie Pizza", 14.99m });

            migrationBuilder.InsertData(
                table: "Foods",
                columns: new[] { "FoodId", "Description", "Name", "Price" },
                values: new object[] { 5, "Mozzarella, Parmesan, Basil, Fresh tomatoes, Tomato sauce", "Margherita Pizza", 10.99m });

            migrationBuilder.InsertData(
                table: "Foods",
                columns: new[] { "FoodId", "Description", "Name", "Price" },
                values: new object[] { 6, "Minced meat, Bacon, Jalapeño, Mozzarella, Parmesan, Olives, Tomatoes", "Pizza with Minced Meat", 15.99m });

            migrationBuilder.InsertData(
                table: "Foods",
                columns: new[] { "FoodId", "Description", "Name", "Price" },
                values: new object[] { 7, "Salami, Chilli, Jalapeño, Mozzarella, Parmesan, Tomato sauce", "Hot Salami Pizza", 14.99m });

            migrationBuilder.InsertData(
                table: "Foods",
                columns: new[] { "FoodId", "Description", "Name", "Price" },
                values: new object[] { 8, "Grilled meat, Tomatoes, Bell pepper, Onion, Mozzarella, Parmesan", "Pizza with Grilled Meat", 16.99m });

            migrationBuilder.InsertData(
                table: "Reservations",
                columns: new[] { "Id", "Email", "Fname", "Lname", "Note", "People", "PhoneNumber", "ReserveDate", "ReserveTime" },
                values: new object[] { 1, "ithan@gmail.com", "Ithan", "Sandoval", "n/a", 5, "215-123-4567", new DateTime(2023, 4, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), "6:30 PM" });

            migrationBuilder.InsertData(
                table: "Reservations",
                columns: new[] { "Id", "Email", "Fname", "Lname", "Note", "People", "PhoneNumber", "ReserveDate", "ReserveTime" },
                values: new object[] { 2, "Peter@gmail.com", "Peter", "Hoang", "n/a", 4, "267-999-999", new DateTime(2023, 4, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), "7:30 PM" });

            migrationBuilder.InsertData(
                table: "Reservations",
                columns: new[] { "Id", "Email", "Fname", "Lname", "Note", "People", "PhoneNumber", "ReserveDate", "ReserveTime" },
                values: new object[] { 3, "Kevin@gmail.com", "Kevin", "Nguyen", "n/a", 4, "610-123-4567", new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "5:30 PM" });
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
