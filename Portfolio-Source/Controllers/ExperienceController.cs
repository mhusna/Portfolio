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
            ViewBag.Message = "Experience List";
            ViewBag.Controller = "Experience";
            ViewBag.Action = "Index";
            return View(experienceManager.TGetList());
        }

        [HttpGet]
        public IActionResult AddExperience()
        {
            ViewBag.Message = "New Experience";
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

        public IActionResult DeleteExperience(int id)
        {
            experienceManager.TDelete(experienceManager.TGetById(id));
            return RedirectToAction("Index");
        }

        [HttpGet]
        public IActionResult EditExperience(int id)
        {
            ViewBag.Message = "Edit Experience";
            ViewBag.Controller = "Experience";
            ViewBag.Action = "EditExperience";
            return View(experienceManager.TGetById(id));
        }

        [HttpPost]
        public IActionResult EditExperience(Experience experience)
        {
            experienceManager.TUpdate(experience);
            return RedirectToAction("Index");
        }
    }
}
