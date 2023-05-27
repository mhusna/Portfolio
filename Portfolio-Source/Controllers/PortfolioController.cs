using BusinessLayer.Concrete;
using BusinessLayer.ValidationRules;
using DataAccessLayer.Concrete.Repository.EfRepository;
using EntityLayer.Concrete;
using FluentValidation;
using FluentValidation.Results;
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

            PortfolioValidator portfolioValidator = new PortfolioValidator();
            ValidationResult validationResult = portfolioValidator.Validate(portfolio);

            if (validationResult.IsValid)
            {
                portfolioManager.TAdd(portfolio);
                return RedirectToAction("Index");
            }
            else
            {
                foreach (var item in validationResult.Errors)
                    ModelState.AddModelError(item.PropertyName, item.ErrorMessage);
            }

            return RedirectToAction("AddPortfolio");
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

            PortfolioValidator portfolioValidator = new PortfolioValidator();
            ValidationResult validationResult = portfolioValidator.Validate(portfolio);

            if (validationResult.IsValid)
            {
                portfolioManager.TUpdate(portfolio);
                return RedirectToAction("Index");
            }
            else
            {
                foreach (var item in validationResult.Errors)
                    ModelState.AddModelError(item.PropertyName, item.ErrorMessage);
            }

            return RedirectToAction("EditPortfolio");
        }

    }
}
