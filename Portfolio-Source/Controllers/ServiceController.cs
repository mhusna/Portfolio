using BusinessLayer.Concrete;
using DataAccessLayer.Concrete.Repository.EfRepository;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace Portfolio_Source.Controllers
{
    public class ServiceController : Controller
    {
        ServiceManager serviceManager = new ServiceManager(new EfServiceRepository());
        public IActionResult Index()
        {
            ViewBag.Message = "## Service List ##";
            ViewBag.Controller = "Service";
            ViewBag.Action = "Index";

            return View(serviceManager.TGetList());
        }

        [HttpGet]
        public IActionResult AddService()
        {
            ViewBag.Message = "## Insert New Service ##";
            ViewBag.Controller = "Service";
            ViewBag.Action = "AddService";

            return View();
        }

        [HttpPost]
        public IActionResult AddService(Service service)
        {
            serviceManager.TAdd(service);
            return RedirectToAction("Index");
        }

        [HttpGet]
        public IActionResult EditService(int id)
        {
            ViewBag.Message = "## Edit Service ##";
            ViewBag.Controller = "Service";
            ViewBag.Action = "EditService";

            return View(serviceManager.TGetById(id));
        }

        [HttpPost]
        public IActionResult EditService(Service service)
        {
            serviceManager.TUpdate(service);
            return RedirectToAction("Index");
        }

        public IActionResult DeleteService(int id)
        {
            serviceManager.TDelete(serviceManager.TGetById(id));
            return RedirectToAction("Index");
        }
    }
}
