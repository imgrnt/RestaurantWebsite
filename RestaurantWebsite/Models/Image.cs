using System.ComponentModel.DataAnnotations;
using RestaurantWebsite.Models;
using System.Collections.Generic;


namespace RestaurantWebsite.Models
{
    public class Image
    {
  
        public int ImageId { get; set; } // primary key property

        [Required(ErrorMessage = "Please enter an image name.")]
        public string? ImageName { get; set; }
        public string? FileName { get; set; }
        public List<Food> Foods { get; set; } //collection navigation property, which includes references to many related entities.


        public string Slug
        {
            get
            {
                if (FileName == null)
                    return "";
                else
                    return FileName.Replace(' ', '-');
            }
        }


    }
}
