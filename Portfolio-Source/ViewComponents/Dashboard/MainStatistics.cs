using BusinessLayer.Concrete;
using DataAccessLayer.Concrete.Repository.EfRepository;
using Microsoft.AspNetCore.Mvc;

namespace Portfolio_Source.ViewComponents.Dashboard
{
    public class MainStatistics:ViewComponent
    {
        PortfolioManager portfolioManager = new PortfolioManager(new EfPortfolioRepository());
        ServiceManager serviceManager = new ServiceManager(new EfServiceRepository());
        ExperienceManager experienceManager = new ExperienceManager(new EfExperienceRepository());
        public IViewComponentResult Invoke()
        {
            ViewBag.Services = serviceManager.TGetList().Count;
            ViewBag.Portfolios = portfolioManager.TGetList().Count;
            ViewBag.Experiences = experienceManager.TGetList().Count;
            return View();
        }
    }
}
