using BusinessLayer.Concrete;
using DataAccessLayer.Concrete.Repository.EfRepository;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace Portfolio_Source.Controllers
{
    public class FeatureController : Controller
    {
        FeatureManager featureManager = new FeatureManager(new EfFeatureRepository());
        public IActionResult Index()
        {
            ViewBag.Message = "Feature List";
            ViewBag.Controller = "Feature";
            ViewBag.Action = "Index";

            return View(featureManager.TGetList());
        }

        [HttpGet]
        public IActionResult EditFeature(int id)
        {
            ViewBag.Message = "Edit Feature";
            ViewBag.Controller = "Feature";
            ViewBag.Action = "EditFeature";

            return View(featureManager.TGetById(id));
        }

        [HttpPost]
        public IActionResult EditFeature(Feature feature)
        {
            featureManager.TUpdate(feature);
            return RedirectToAction("Index", "Default");
        }
    }
}
