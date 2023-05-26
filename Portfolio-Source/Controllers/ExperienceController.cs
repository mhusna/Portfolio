using BusinessLayer.Concrete;
using DataAccessLayer.Concrete.Repository.EfRepository;
using EntityLayer.Concrete;
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

        [HttpPost]
        public IActionResult AddExperience(Experience experience)
        {
            experienceManager.TAdd(experience);
            return RedirectToAction("Index");
        }
    }
}
