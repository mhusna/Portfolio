using BusinessLayer.Concrete;
using DataAccessLayer.Concrete.Repository.EfRepository;
using Microsoft.AspNetCore.Mvc;

namespace Portfolio_Source.ViewComponents.Dashboard
{
    public class ProjectsList:ViewComponent
    {
        PortfolioManager portfolioManager = new PortfolioManager(new EfPortfolioRepository());
        public IViewComponentResult Invoke()
        {
            return View(portfolioManager.TGetList());
        }
    }
}
