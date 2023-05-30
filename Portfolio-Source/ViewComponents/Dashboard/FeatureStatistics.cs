using Microsoft.AspNetCore.Mvc;

namespace Portfolio_Source.ViewComponents.Dashboard
{
    public class FeatureStatistics:ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
