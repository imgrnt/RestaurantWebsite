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

            migrationBuilder.InsertData(
                table: "Foods",
                columns: new[] { "MenuId", "Name", "Price" },
                values: new object[] { 1, "Plain Pizza", 10.0 });

            migrationBuilder.InsertData(
                table: "Foods",
                columns: new[] { "MenuId", "Name", "Price" },
                values: new object[] { 2, "Neopolitan Pizza", 13.449999999999999 });

            migrationBuilder.InsertData(
                table: "Foods",
                columns: new[] { "MenuId", "Name", "Price" },
                values: new object[] { 3, "White Pizza", 11.0 });

            migrationBuilder.InsertData(
                table: "Foods",
                columns: new[] { "MenuId", "Name", "Price" },
                values: new object[] { 4, "Philly Pizza", 14.449999999999999 });

            migrationBuilder.InsertData(
                table: "Foods",
                columns: new[] { "MenuId", "Name", "Price" },
                values: new object[] { 5, "House Special Pizza", 15.0 });

            migrationBuilder.InsertData(
                table: "Foods",
                columns: new[] { "MenuId", "Name", "Price" },
                values: new object[] { 6, "Meat Lovers Pizza", 13.449999999999999 });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Foods");
        }
    }
}
