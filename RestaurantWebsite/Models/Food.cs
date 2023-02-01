using System.ComponentModel.DataAnnotations;

namespace RestaurantWebsite.Models
{
    public class Food
    {
        [Key]
        public int MenuId { get; set; }

        public string? Name { get; set; }

        public double? Price { get; set; }


    }
}
