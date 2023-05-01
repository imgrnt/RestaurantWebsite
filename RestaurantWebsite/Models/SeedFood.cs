using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using System.Reflection.Emit;

namespace RestaurantWebsite.Models
{
    internal class SeedFood : IEntityTypeConfiguration<Food>
    {
        public void Configure(EntityTypeBuilder<Food> entity)
        {
            // Configure a one-to-many relationship (Food and Image)
            entity.HasOne(m => m.Image)
                .WithMany(f => f.Foods);


            // Food: remove cascading delete with Image
            entity.HasOne(b => b.Image)
                .WithMany(f => f.Foods)
                .OnDelete(DeleteBehavior.Restrict);



            entity.HasData(

                new Food
                {
                    FoodId = 1,
                    ImageId = 1,
                    Name = "Plain Pizza",
                    Price = (decimal)10.00,
                    Description = "Homemade pizza sauce, Mozzarella cheese, Parmesan cheese"
                },

                new Food
                {
                    FoodId = 2,
                    ImageId = 2,
                    Name = "Pepperoni Pizza",
                    Price = (decimal)14.99,
                    Description = "Pepperoni, Tomatoes, Paprika, Chili, Mozzarella, Parmesan"
                },
                new Food
                {
                    FoodId = 3,
                    ImageId = 3,
                    Name = "Pizza with Salami and Olives",
                    Price = (decimal)15.99,
                    Description = "Salami, Olives, Bell pepper, Mushrooms, Mozzarella, Parmesan"
                },
                new Food
                {
                    FoodId = 4,
                    ImageId = 4,
                    Name = "Veggie Pizza",
                    Price = (decimal)14.99,
                    Description = "Broccoli, Mushrooms, Bell pepper, Corn, Onion, Mozzarella, Parmesan"
                },
                new Food
                {
                    FoodId = 5,
                    ImageId = 5,
                    Name = "Margherita Pizza",
                    Price = (decimal)10.99,
                    Description = "Mozzarella, Parmesan, Basil, Fresh tomatoes, Tomato sauce"
                },
                new Food
                {
                    FoodId = 6,
                    ImageId = 6,
                    Name = "Pizza with Minced Meat",
                    Price = (decimal)15.99,
                    Description = "Minced meat, Bacon, Jalapeño, Mozzarella, Parmesan, Olives, Tomatoes"
                },
                new Food
                {
                    FoodId = 7,
                    ImageId = 7,
                    Name = "Hot Salami Pizza",
                    Price = (decimal)14.99,
                    Description = "Salami, Chilli, Jalapeño, Mozzarella, Parmesan, Tomato sauce"
                },
                new Food
                {
                    FoodId = 8,
                    ImageId = 8,
                    Name = "Pizza with Grilled Meat",
                    Price = (decimal)16.99,
                    Description = "Grilled meat, Tomatoes, Bell pepper, Onion, Mozzarella, Parmesan"
                }
            );


        }
    }
}
