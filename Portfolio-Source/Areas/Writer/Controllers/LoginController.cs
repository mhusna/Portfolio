using EntityLayer.Concrete;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore.ChangeTracking;
using Portfolio_Source.Areas.Writer.Models;

namespace Portfolio_Source.Areas.Writer.Controllers
{
    [Area("Writer")]
    public class LoginController : Controller
    {
        private readonly SignInManager<WriterUser> _signInManager;

        public LoginController(SignInManager<WriterUser> signInManager)
        {
            _signInManager = signInManager;
        }
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Index(UserLoginViewModel model)
        {
            if(ModelState.IsValid)
            {
                var result = await _signInManager.PasswordSignInAsync(model.UserName, model.Password, true, true);

                if (result.Succeeded)
                    return RedirectToAction("Index", "Default");
                else
                    ModelState.AddModelError("", "Wrong username or password.");
            }

            return View();
        }
    }
}
