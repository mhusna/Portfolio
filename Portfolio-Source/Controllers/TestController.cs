using Microsoft.AspNetCore.Mvc;

namespace Portfolio_Source.Controllers
{
    public class TestController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
