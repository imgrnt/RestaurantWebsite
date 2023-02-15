using Microsoft.EntityFrameworkCore;

namespace RestaurantWebsite.Models
{
    public class FoodContext : DbContext
    {
        public FoodContext(DbContextOptions<FoodContext> options): base(options){ }

        public DbSet<Food> Foods { get; set; }
        public DbSet<Reservation> Reservations { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

            modelBuilder.Entity<Food>().HasData(
                new Food
                {
                    MenuId = 1,
                    Name = "Plain Pizza",
                    Price = 10.00
                },

                new Food
                {
                    MenuId = 2,
                    Name = "Pepperoni Pizza",
                    Price = 14.99
                },
                new Food
                {
                    MenuId = 3,
                    Name = "Pizza with Salami and Olives",
                    Price = 15.99
                },
                new Food
                {
                    MenuId = 4,
                    Name = "Quattro Pizza Formaggi",
                    Price = 14.99
                },
                new Food
                {
                    MenuId = 5,
                    Name = "Margherita Pizza",
                    Price = 10.99
                },
                new Food
                {
                    MenuId = 6,
                    Name = "Pizza with Minced Meat",
                    Price = 15.99
                },
                new Food
                {
                    MenuId = 7,
                    Name = "Hot Salami Pizza",
                    Price = 14.99
                },
                new Food
                {
                    MenuId = 8,
                    Name = "Pizza with Grilled Meat",
                    Price = 16.99
                }
            );

            modelBuilder.Entity<Reservation>().HasData(
                new Reservation { Id = 1, Fname = "Ana", Lname = "Marie", Email = "AnaMarie@gmail.com", PhoneNumber = "215-123-4567", ReserveDate = DateTime.Parse("2020 01, 22"), ReserveTime = "6:30 PM", People = 5, Note = "n/a" }
            );

        }
    }
}
