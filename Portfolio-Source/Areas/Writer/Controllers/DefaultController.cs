using Microsoft.AspNetCore.Mvc;

namespace Portfolio_Source.Areas.Writer.Controllers
{
    public class DefaultController : Controller
    {
        [Area("Writer")]
        public IActionResult Index()
        {
            return View();
        }
    }
}
