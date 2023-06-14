using BusinessLayer.Concrete;
using DataAccessLayer.Concrete.Repository.EfRepository;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System.Xml.Linq;

namespace Portfolio_Source.Areas.Writer.Controllers
{
    [Area("Writer")]
    public class DashboardController : Controller
    {
        private readonly UserManager<WriterUser> _userManager;

        public DashboardController(UserManager<WriterUser> userManager)
        {
            _userManager = userManager;
        }

        public async Task<IActionResult> Index()
        {
            var user = await _userManager.FindByNameAsync(User.Identity.Name);
            ViewBag.FullName = user.FirstName + " "+ user.LastName;

            //Weather API
            string key = "8a66d901eee5089c9df93bdc7f0f1d45";
            string url = "https://api.openweathermap.org/data/2.5/weather?q=istanbul&mode=xml&lang=tr&units=metric&appid="+key;

            XDocument document = XDocument.Load(url);
            ViewBag.Temperature = document.Descendants("temperature").ElementAt(0).Attribute("value").Value;

            //Statistics 
            AnnouncementManager announcementManager = new AnnouncementManager(new EfAnnouncementRepository());
            ViewBag.Announcements = announcementManager.TGetList().Count;
            ViewBag.Messages = 0;
            return View();
        }
    }
}
