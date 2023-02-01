using Microsoft.EntityFrameworkCore;

namespace RestaurantWebsite.Models
{
    public class FoodContext : DbContext
    {
        public FoodContext(DbContextOptions<FoodContext> options)
    : base(options)
        { }
        public DbSet<Food> Foods { get; set; }
        protected override void OnModelCreating(
            ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

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
                    Name = "Neopolitan Pizza",
                    Price = 13.45
                },
                new Food
                {
                    MenuId = 3,
                    Name = "White Pizza",
                    Price = 11.00
                },
                new Food
                {
                    MenuId = 4,
                    Name = "Philly Pizza",
                    Price = 14.45
                },
                new Food
                {
                    MenuId = 5,
                    Name = "House Special Pizza",
                    Price = 15.00
                },
                new Food
                {
                    MenuId = 6,
                    Name = "Meat Lovers Pizza",
                    Price = 13.45
                }
            );
        }
    }
}
