using BusinessLayer.Concrete;
using DataAccessLayer.Concrete.Repository.EfRepository;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace Portfolio_Source.Controllers
{
    public class SkillController : Controller
    {
        SkillManager skillManager = new SkillManager(new EfSkillRepository());
        public IActionResult Index()
        {
            ViewBag.Message = "List of Skills";
            ViewBag.Controller = "Skill";
            ViewBag.Action = "Index";

            return View(skillManager.TGetList());
        }

        [HttpGet]
        public IActionResult AddSkill()
        {
            ViewBag.Message = "Add New Skill";
            ViewBag.Controller = "Skill";
            ViewBag.Action = "AddSkill";
            return View();
        }

        [HttpPost]
        public IActionResult AddSkill(Skill skill)
        {
            skillManager.TAdd(skill);
            return RedirectToAction("Index");
        }

        [HttpGet]
        public IActionResult DeleteSkill(int id)
        {
            skillManager.TDelete(skillManager.TGetById(id));
            return RedirectToAction("Index");
        }

        [HttpGet]
        public IActionResult EditSkill(int id)
        {
            ViewBag.Message = "Edit Skill";
            ViewBag.Controller = "Skill";
            ViewBag.Action = "EditSkill";
            return View(skillManager.TGetById(id));
        }

        [HttpPost]
        public IActionResult EditSkill(Skill skill)
        {
            skillManager.TUpdate(skill);
            return RedirectToAction("Index");
        }
    }
}
