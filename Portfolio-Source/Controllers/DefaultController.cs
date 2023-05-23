using BusinessLayer.Concrete;
using DataAccessLayer.Concrete.Repository.EfRepository;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace Portfolio_Source.Controllers
{
    public class DefaultController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public PartialViewResult HeaderPartial()
        {
            return PartialView();
        }

        [HttpGet]
        public PartialViewResult SendMessage()
        {
            return PartialView();
        }

        [HttpPost]
        public IActionResult SendMessage(Message message)
        {
            MessageManager messageManager = new MessageManager(new EfMessageRepository());

            message.Date = Convert.ToDateTime(DateTime.Now.ToShortDateString());
            message.Status = true;

            messageManager.TAdd(message);

            return RedirectToAction("Index", "Default");
        }
    }
}
