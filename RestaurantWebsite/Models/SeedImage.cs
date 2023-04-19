using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using System.Reflection.Emit;

namespace RestaurantWebsite.Models
{
    internal class SeedImage : IEntityTypeConfiguration<Image>
    {
        public void Configure(EntityTypeBuilder<Image> entity)
        {
            entity.HasData(

                new Image
                {
                    ImageId = 1,
                    ImageName = "Plain Pizza",
                    FileName = "plain_pizza.jpg"
                },

                new Image
                {
                    ImageId = 2,
                    ImageName = "Pepperoni Pizza",
                    FileName = "pepperoni_pizza.jpg"
                },
                new Image
                {
                    ImageId = 3,
                    ImageName = "Pizza with Salami and Olives",
                    FileName = "pizza_with_salami_and_olives.jpg"
                },
                new Image
                {
                    ImageId = 4,
                    ImageName = "Veggie Pizza",
                    FileName = "veggie_pizza.jpg"
                },
                new Image
                {
                    ImageId = 5,
                    ImageName = "Margherita Pizza",
                    FileName = "margherita_pizza.jpg"
                },
                new Image
                {
                    ImageId = 6,
                    ImageName = "Pizza with Minced Meat",
                    FileName = "pizza_with_minced_meat.jpg"
                },
                new Image
                {
                    ImageId = 7,
                    ImageName = "Hot Salami Pizza",
                    FileName = "hot_salami_pizza.jpg"
                },
                new Image
                {
                    ImageId = 8,
                    ImageName = "Pizza with Grilled Meat",
                    FileName = "pizza_with_grilled_meat.jpg"
                }
            );


        }
    }
}
