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
            return View(featureManager.TGetList());
        }

        [HttpGet]
        public IActionResult AddFeature()
        {
            ViewBag.Message = "## Insert New Feature ##";
            ViewBag.Controller = "Feature";
            ViewBag.Action = "AddFeature";

            return View();
        }

        [HttpPost]
        public IActionResult AddFeature(Feature feature)
        {
            featureManager.TAdd(feature);
            return RedirectToAction("Index");
        }

        [HttpGet]
        public IActionResult EditFeature(int id)
        {
            ViewBag.Message = "## Edit Feature ##";
            ViewBag.Controller = "Feature";
            ViewBag.Action = "EditFeature";

            return View(featureManager.TGetById(id));
        }

        [HttpPost]
        public IActionResult EditFeature(Feature feature)
        {
            featureManager.TUpdate(feature);
            return RedirectToAction("Index");
        }

        public IActionResult DeleteFeature(int id)
        {
            featureManager.TDelete(featureManager.TGetById(id));
            return RedirectToAction("Index");
        }
    }
}
