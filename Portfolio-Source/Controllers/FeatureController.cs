using Microsoft.AspNetCore.Mvc;

namespace Portfolio_Source.Controllers
{
    public class FeatureController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
