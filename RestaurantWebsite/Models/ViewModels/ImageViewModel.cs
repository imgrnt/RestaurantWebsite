using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace RestaurantWebsite.Models
{
    public class ImageViewModel 
    {
        public string ImageName { get; set; }

        public IFormFile FileName { get; set; }

    }
}
