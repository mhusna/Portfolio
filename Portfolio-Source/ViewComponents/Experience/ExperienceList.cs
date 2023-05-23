using BusinessLayer.Abstract;
using BusinessLayer.Concrete;
using DataAccessLayer.Concrete.Repository.EfRepository;
using Microsoft.AspNetCore.Mvc;

namespace Portfolio_Source.ViewComponents.Experience
{
    public class ExperienceList:ViewComponent
    {
        ExperienceManager experienceManager = new ExperienceManager(new EfExperienceRepository());

        public IViewComponentResult Invoke()
        {
            return View(experienceManager.TGetList());
        }
    }
}
