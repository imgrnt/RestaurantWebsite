using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using System.Reflection.Emit;

namespace RestaurantWebsite.Models
{
    internal class SeedFood : IEntityTypeConfiguration<Food>
    {
        public void Configure(EntityTypeBuilder<Food> entity)
        {
            entity.HasData(

                new Food
                {
                    FoodId = 1,
                    Name = "Plain Pizza",
                    Price = (decimal)10.00
                },

                new Food
                {
                    FoodId = 2,
                    Name = "Pepperoni Pizza",
                    Price = (decimal)14.99
                },
                new Food
                {
                    FoodId = 3,
                    Name = "Pizza with Salami and Olives",
                    Price = (decimal)15.99
                },
                new Food
                {
                    FoodId = 4,
                    Name = "Quattro Pizza Formaggi",
                    Price = (decimal)14.99
                },
                new Food
                {
                    FoodId = 5,
                    Name = "Margherita Pizza",
                    Price = (decimal)10.99
                },
                new Food
                {
                    FoodId = 6,
                    Name = "Pizza with Minced Meat",
                    Price = (decimal)15.99
                },
                new Food
                {
                    FoodId = 7,
                    Name = "Hot Salami Pizza",
                    Price = (decimal)14.99
                },
                new Food
                {
                    FoodId = 8,
                    Name = "Pizza with Grilled Meat",
                    Price = (decimal)16.99
                }
            );


        }
    }
}
