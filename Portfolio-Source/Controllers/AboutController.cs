using BusinessLayer.Concrete;
using DataAccessLayer.Concrete.Repository.EfRepository;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace Portfolio_Source.Controllers
{
    public class AboutController : Controller
    {
        AboutManager aboutManager = new AboutManager(new EfAboutRepository());
        public IActionResult Index()
        {
            ViewBag.Message = "## About List ##";
            ViewBag.Controller = "About";
            ViewBag.Action = "Index";

            return View(aboutManager.TGetList());
        }

        [HttpGet]
        public IActionResult EditAbout(int id)
        {
            ViewBag.Message = "## Edit About ##";
            ViewBag.Controller = "About";
            ViewBag.Action = "EditAbout";

            return View(aboutManager.TGetById(id));
        }

        [HttpPost]
        public IActionResult EditAbout(About about)
        {
            aboutManager.TUpdate(about);
            return RedirectToAction("Index", "Default");
        }
    }
}
