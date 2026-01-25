    using Microsoft.AspNetCore.Mvc;
    using ResumeProject.Context;
    using ResumeProject.Entities;

    namespace ResumeProject.Controllers
    {
        public class SkillController : Controller
        {
        private readonly ResumeContext _context;

        public SkillController(ResumeContext context)
        {
            _context = context;
        }

        public IActionResult SkillList()
        {
            var skills = _context.Skills.ToList();
            return View(skills);
        }

        [HttpGet]
        public IActionResult CreateSkill()
        {
            return View();
        }

        [HttpPost]
        public IActionResult CreateSkill(Skill skill)
        {
            var aboutId = _context.Abouts.Select(x => x.AboutId).FirstOrDefault();

            skill.AboutId = aboutId; // 🔴 KRİTİK SATIR

            _context.Skills.Add(skill);
            _context.SaveChanges();
            return RedirectToAction("SkillList");
        }

        public IActionResult DeleteSkill(int id)
        {
            var skill = _context.Skills.Find(id);
            _context.Skills.Remove(skill);
            _context.SaveChanges();
            return RedirectToAction("SkillList");
        }

        [HttpGet]
        public IActionResult UpdateSkill(int id)
        {
            var skill = _context.Skills.Find(id);
            return View(skill);
        }

        [HttpPost]
        public IActionResult UpdateSkill(Skill skill)
        {
            var value = _context.Skills.Find(skill.SkillId);
            value.Title = skill.Title;
            value.Percent = skill.Percent;
            _context.SaveChanges();
            return RedirectToAction("SkillList");
        }
    }
    }
