using BusinessLayer.Concrete;
using DataAccessLayer.Concrete.Repository.EfRepository;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Infrastructure;
using Portfolio_Source.Models;

namespace Portfolio_Source.ViewComponents.Dashboard
{
    public class MessageList:ViewComponent
    {
        UserMessageManager userMessageManager = new UserMessageManager(new EfUserMessageRepository());

        public IViewComponentResult Invoke()
        {
            return View(userMessageManager.GetUserMessagesWithUserService());
        }
    }
}
