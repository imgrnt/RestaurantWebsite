using System;
using System.ComponentModel.DataAnnotations;
using System.Xml.Linq;

namespace RestaurantWebsite.Models
{
    public class Reservation
    {

        public int Id { get; set; }

        [Required(ErrorMessage = "Please enter a first name")]
        public string Fname { get; set; }

        [Required(ErrorMessage = "Please enter a last name")]
        public string Lname { get; set; }

        // might need to edit this [EmailAddressAttribute]
        [EmailAddress(ErrorMessage = "InvalidEmailAddress")]
        [Required(ErrorMessage = "Please enter an email address.")]
        [Display(Name = "Email")]
        public string Email { get; set; }

        // might need to edit this [phoneAttibute]
        [Phone]
        [Required(ErrorMessage = "Please enter a phone number.")]
        public string PhoneNumber { get; set; }

        [Required(ErrorMessage = "Please enter a reservation date")]
        public DateTime? ReserveDate { get; set; }

        // might need to edit this [TimeOnly]
        [Required(ErrorMessage = "Please enter a reservation time")]
        public string ReserveTime { get; set; }

        [Required(ErrorMessage = "Please the number of people")]
        public int People { get; set; }

        [Required(ErrorMessage = "Please enter any notes.")]
        public string Note { get; set; }


        public string Slug
        {
            get
            {
                if (Fname == null)
                    return "";
                else
                    return Fname.Replace(' ', '-') + '-' + Lname.Replace(' ', '-');
            }
        }



    }
}
