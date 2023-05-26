using BusinessLayer.Concrete;
using DataAccessLayer.Concrete.Repository.EfRepository;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace Portfolio_Source.Controllers
{
    public class PortfolioController : Controller
    {
        PortfolioManager portfolioManager = new PortfolioManager(new EfPortfolioRepository());
        public IActionResult Index()
        {
            ViewBag.Message = "## Portfolio List ##";
            ViewBag.Controller = "Portfolio";
            ViewBag.Action = "Index";

            return View(portfolioManager.TGetList());
        }

        [HttpGet]
        public IActionResult AddPortfolio()
        {
            ViewBag.Message = "## Insert New Portfolio ##";
            ViewBag.Controller = "Portfolio";
            ViewBag.Action = "AddPortfolio";

            return View();
        }

        [HttpPost]
        public IActionResult AddPortfolio(Portfolio portfolio)
        {
            portfolioManager.TAdd(portfolio);
            return RedirectToAction("Index");
        }

        public IActionResult DeletePortfolio(int id)
        {
            portfolioManager.TDelete(portfolioManager.TGetById(id));
            return RedirectToAction("Index");
        }

        [HttpGet]
        public IActionResult EditPortfolio(int id)
        {
            ViewBag.Message = "## Edit Portfolio ##";
            ViewBag.Controller = "Portfolio";
            ViewBag.Action = "EditPortfolio";

            return View(portfolioManager.TGetById(id));
        }

        [HttpPost]
        public IActionResult EditPortfolio(Portfolio portfolio)
        {
            portfolioManager.TUpdate(portfolio);
            return RedirectToAction("Index");
        }

    }
}
