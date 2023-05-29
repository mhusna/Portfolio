using BusinessLayer.Concrete;
using DataAccessLayer.Concrete.Repository.EfRepository;
using Microsoft.AspNetCore.Mvc;

namespace Portfolio_Source.Controllers
{
    public class AboutController : Controller
    {
        AboutManager aboutManager = new AboutManager(new EfAboutRepository());
        public IActionResult Index()
        {
            return View(aboutManager.TGetList());
        }

    }
}
