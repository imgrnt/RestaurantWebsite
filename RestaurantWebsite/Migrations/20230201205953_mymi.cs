using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace RestaurantWebsite.Migrations
{
    public partial class mymi : Migration
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
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Foods");
        }
    }
}
