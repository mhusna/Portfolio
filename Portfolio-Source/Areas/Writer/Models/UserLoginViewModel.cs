using System.ComponentModel.DataAnnotations;

namespace Portfolio_Source.Areas.Writer.Models
{
    public class UserLoginViewModel
    {
        [Display(Name = "User Name")]
        [Required(ErrorMessage = "Enter the user name...")]
        public string UserName { get; set; }

        [Display(Name = "Password")]
        [Required(ErrorMessage = "Enter the password...")]
        public string Password { get; set; }
    }
}
