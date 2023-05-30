using BusinessLayer.Concrete;
using DataAccessLayer.Concrete.Repository.EfRepository;
using Microsoft.AspNetCore.Mvc;

namespace Portfolio_Source.ViewComponents.Dashboard
{
    public class Projects:ViewComponent
    {
        PortfolioManager portfolioManager = new PortfolioManager(new EfPortfolioRepository());
        public IViewComponentResult Invoke()
        {
            return View(portfolioManager.TGetList().GetRange(portfolioManager.TGetList().Count() - 5, 5));
        }
    }
}
