using BusinessLayer.Concrete;
using DataAccessLayer.Concrete.Repository.EfRepository;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Portfolio_Source.Areas.Writer.Controllers
{
    [Area("Writer")]
    public class DefaultController : Controller
    {
        AnnouncementManager announcementManager = new AnnouncementManager(new EfAnnouncementRepository());

        [Authorize]
        public IActionResult Index()
        {
            return View(announcementManager.TGetList());
        }

        public IActionResult AnnouncementDetails(int id)
        {
            return View(announcementManager.TGetById(id));
        }

    }
}
