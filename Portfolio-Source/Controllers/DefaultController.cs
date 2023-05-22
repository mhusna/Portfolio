using Microsoft.AspNetCore.Mvc;

namespace Portfolio_Source.Controllers
{
    public class DefaultController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
