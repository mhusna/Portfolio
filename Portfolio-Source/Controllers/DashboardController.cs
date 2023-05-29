using Microsoft.AspNetCore.Mvc;

namespace Portfolio_Source.Controllers
{
    public class DashboardController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
