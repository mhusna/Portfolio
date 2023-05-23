using Microsoft.AspNetCore.Mvc;

namespace Portfolio_Source.ViewComponents.Contact
{
    public class SendMessage:ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
