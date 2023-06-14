using Microsoft.AspNetCore.Mvc;

namespace Portfolio_Source.Areas.Writer.ViewComponents.Notification
{
    public class NotificationList : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
