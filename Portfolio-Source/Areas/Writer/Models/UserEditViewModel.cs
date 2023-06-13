namespace Portfolio_Source.Areas.Writer.Models
{
    public class UserEditViewModel
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Password { get; set; }
        public string PasswordConfirm { get; set; }
        public string ImageUrl { get; set; }
        public IFormFile Picture { get; set; }
    }
}
