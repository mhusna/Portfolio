using BusinessLayer.Concrete;
using DataAccessLayer.Concrete.Repository.EfRepository;
using Microsoft.AspNetCore.Mvc;

namespace Portfolio_Source.ViewComponents.Dashboard
{
    public class TopStatistics:ViewComponent
    {
        MessageManager messageManager = new MessageManager(new EfMessageRepository());
        public IViewComponentResult Invoke()
        {
            ViewBag.UnreadMessages = messageManager.TGetList().Where(message => message.Status == false).Count();
            ViewBag.ReadMessages = messageManager.TGetList().Where(message => message.Status == true).Count();

            return View();
        }
    }
}
