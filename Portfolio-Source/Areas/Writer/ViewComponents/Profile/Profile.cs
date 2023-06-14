using EntityLayer.Concrete;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace Portfolio_Source.Areas.Writer.ViewComponents.Profile
{
    public class Profile:ViewComponent
    {
        private readonly UserManager<WriterUser> _userManager;

        public Profile(UserManager<WriterUser> userManager)
        {
            _userManager = userManager;
        }

        public async Task<IViewComponentResult> InvokeAsync()
        {
            var user = await _userManager.FindByNameAsync(User.Identity.Name);
            ViewBag.ImageUrl = user.ImageUrl;

            return View();
        }
    }
}
