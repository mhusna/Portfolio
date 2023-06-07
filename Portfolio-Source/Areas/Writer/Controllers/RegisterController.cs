using Microsoft.AspNetCore.Mvc;
using Portfolio_Source.Areas.Writer.Models;

namespace Portfolio_Source.Areas.Writer.Controllers
{
    [Area("Writer")]
    public class RegisterController : Controller
    {
        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Index(UserRegisterViewModel model)
        {
            if(ModelState.IsValid)
            {

            }
            return View();
        }
    }
}
