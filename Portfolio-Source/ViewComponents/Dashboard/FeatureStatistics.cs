using BusinessLayer.Concrete;
using DataAccessLayer.Concrete.Repository.EfRepository;
using Microsoft.AspNetCore.Mvc;

namespace Portfolio_Source.ViewComponents.Dashboard
{
    public class FeatureStatistics:ViewComponent
    {
        SkillManager skillManager = new SkillManager(new EfSkillRepository());
        MessageManager messageManager = new MessageManager(new EfMessageRepository());
        ExperienceManager experienceManager = new ExperienceManager(new EfExperienceRepository());
        public IViewComponentResult Invoke()
        {
            ViewBag.SkillCount = skillManager.TGetList().Count();
            ViewBag.ExperienceCount = experienceManager.TGetList().Count();
            ViewBag.UnreadMessages = messageManager.TGetList().Where(message => message.Status == false).Count();
            ViewBag.ReadMessages = messageManager.TGetList().Where(message => message.Status == true).Count();

            return View();
        }
    }
}
