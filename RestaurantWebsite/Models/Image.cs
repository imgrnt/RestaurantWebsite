using System.ComponentModel.DataAnnotations;

namespace RestaurantWebsite.Models
{
    public class Image
    {
  
        public int ImageId { get; set; }

        [Required(ErrorMessage = "Please enter the file name.")]
        public string? FileName { get; set; }





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
