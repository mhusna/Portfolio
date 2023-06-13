using EntityLayer.Concrete;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Portfolio_Source.Areas.Writer.Models;

namespace Portfolio_Source.Areas.Writer.Controllers
{
    [Area("Writer")]
    public class ProfileController : Controller
    {
        private readonly UserManager<WriterUser> _userManager;

        public ProfileController(UserManager<WriterUser> userManager)
        {
            _userManager = userManager;
        }

        [HttpGet]
        public async Task<IActionResult> Index()
        {
            var value = await _userManager.FindByNameAsync(User.Identity.Name);

            UserEditViewModel model = new UserEditViewModel();
            model.FirstName = value.FirstName;
            model.LastName = value.LastName;
            model.ImageUrl = value.ImageUrl;

            return View(model);
        }

        [HttpPost]
        public async Task<IActionResult> Index(UserEditViewModel model)
        {
            var user = await _userManager.FindByNameAsync(User.Identity.Name);
            
            if(model.Picture != null)
            {
                var resource = Directory.GetCurrentDirectory();
                var extension = Path.GetExtension(resource);
                var imageName = Guid.NewGuid() + extension;
                var saveLocation = resource + "/wwwroot/user_images/" + imageName;
                var stream = new FileStream(saveLocation, FileMode.Create);

                await model.Picture.CopyToAsync(stream);
                user.ImageUrl = imageName;
            }

            user.FirstName = model.FirstName;
            user.LastName = model.LastName;

            var result = await _userManager.UpdateAsync(user);

            if(result.Succeeded)
            {
                return RedirectToAction("Index", "Default");
            }

            return View();
        }
    }
}
