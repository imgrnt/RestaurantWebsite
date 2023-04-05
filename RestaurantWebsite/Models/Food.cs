using System.ComponentModel.DataAnnotations;

namespace RestaurantWebsite.Models
{
    public class Food
    {
        [Key]
        public int FoodId { get; set; }

        [Required(ErrorMessage = "Please enter the food item's name.")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Please enter the item's price.")]
        [Range(0.00, 150.55, ErrorMessage = "Price must be between 0.25 and 10.50 ")]
        public decimal? Price { get; set; }

        public string Slug
        {
            get
            {
                if (Name == null)
                    return "";
                else
                    return Name.Replace(' ', '-') + '-' + Price.ToString();
            }
        }


    }
}
