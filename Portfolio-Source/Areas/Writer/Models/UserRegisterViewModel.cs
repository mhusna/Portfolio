using System.ComponentModel.DataAnnotations;

namespace Portfolio_Source.Areas.Writer.Models
{
    public class UserRegisterViewModel
    {
        [Required(ErrorMessage = "Please enter the first name.")]
        public string FirstName { get; set; }

        [Required(ErrorMessage = "Please enter the last name.")]
        public string LastName { get; set; }

        [Required(ErrorMessage ="Please enter the user name.")]
        public string UserName { get; set; }

        [Required(ErrorMessage = "Please enter the password.")]
        public string Password { get; set; }

        [Required(ErrorMessage = "Please enter the password again.")]
        [Compare("Password", ErrorMessage ="Passwords are not same.")]
        public string ConfirmPassword { get; set; }

        [Required(ErrorMessage = "Please enter the mail address.")]
        public string Mail  { get; set; }

        [Required(ErrorMessage = "Please enter the image url.")]
        public string ImageUrl { get; set; }

    }
}
