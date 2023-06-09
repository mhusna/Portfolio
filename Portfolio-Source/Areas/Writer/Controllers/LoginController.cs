using EntityLayer.Concrete;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore.ChangeTracking;

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
    }
}
