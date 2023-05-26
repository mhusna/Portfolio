using BusinessLayer.Concrete;
using DataAccessLayer.Concrete.Repository.EfRepository;
using Microsoft.AspNetCore.Mvc;

namespace Portfolio_Source.Controllers
{
    public class ExperienceController : Controller
    {
        ExperienceManager experienceManager = new ExperienceManager(new EfExperienceRepository());
        public IActionResult Index()
        {
            ViewBag.Message = "## Experience List ##";
            ViewBag.Controller = "Experience";
            ViewBag.Action = "Index";
            return View(experienceManager.TGetList());
        }

        [HttpGet]
        public IActionResult AddExperience()
        {
            ViewBag.Message = "## Insert New Experience ##";
            ViewBag.Controller = "Experience";
            ViewBag.Action = "AddExperience";

            return View();
        }
    }
}
