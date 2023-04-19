using System.ComponentModel.DataAnnotations;

namespace RestaurantWebsite.Models
{
    public class Food
    {
        [Key]
        public int FoodId { get; set; }

        [Required(ErrorMessage = "Please enter the food item's name.")]
        public string? Name { get; set; }

        [Required(ErrorMessage = "Please enter the item's price.")]
        [Range(0.00, 200.50, ErrorMessage = "Price must be between 0 and 200.50 ")]
        public decimal? Price { get; set; }


        [Required(ErrorMessage = "Please select an image.")]
        public int ImageId { get; set; }  // foreign key property
        public Image Image { get; set; }     //reference navigation property, which contains a reference to a single related entity

        [Required(ErrorMessage = "Please enter a description.")]
        public string? Description { get; set; }



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
