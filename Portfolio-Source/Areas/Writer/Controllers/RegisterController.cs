using EntityLayer.Concrete;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore.Query.Internal;
using Portfolio_Source.Areas.Writer.Models;

namespace Portfolio_Source.Areas.Writer.Controllers
{
    [Area("Writer")]
    public class RegisterController : Controller
    {
        private readonly UserManager<WriterUser> _userManager;
        public RegisterController(UserManager<WriterUser> userManager)
        {
            _userManager = userManager;
        }

        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Index(UserRegisterViewModel model)
        {
            if(ModelState.IsValid)
            {
                WriterUser writerUser = new WriterUser()
                {
                    FirstName = model.FirstName,
                    LastName = model.LastName,
                    UserName = model.UserName,
                    Email = model.Mail,
                    ImageUrl = model.ImageUrl
                };

                if(model.Password == model.ConfirmPassword)
                {
                    var result = await _userManager.CreateAsync(writerUser, model.Password);

                    if (result.Succeeded)
                        return RedirectToAction("Index", "Login");
                    else
                    {
                        foreach (var item in result.Errors)
                            ModelState.AddModelError("", item.Description);
                    }
                }
            }
            return View();
        }
    }
}
