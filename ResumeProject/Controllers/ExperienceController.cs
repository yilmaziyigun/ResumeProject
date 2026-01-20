using Microsoft.AspNetCore.Mvc;
using ResumeProject.Context;
using ResumeProject.Entities;

namespace ResumeProject.Controllers
{
    public class ExperienceController : Controller
    {
        private readonly ResumeContext _context;

        public ExperienceController(ResumeContext context)
        {
            _context = context;
        }

        public IActionResult ExperienceList()
        {
            var experiences = _context.Experiences.ToList();
            return View(experiences);
        }
        [HttpGet]
        public IActionResult CreateExperience()
        {
            return View();
        }
        [HttpPost]
        public IActionResult CreateExperience(Experience experience)
        {
            if (ModelState.IsValid)
            {
                _context.Experiences.Add(experience);
                _context.SaveChanges();
                return RedirectToAction("ExperienceList");
            }
            return View(experience);
        }
        public IActionResult DeleteExperience(int id)
        {
            var experience = _context.Experiences.Find(id);
            if (experience != null)
            {
                _context.Experiences.Remove(experience);
                _context.SaveChanges();
            }
            return RedirectToAction("ExperienceList");
        }
        [HttpGet]
        public IActionResult UpdateExperience(int id)
        {
            var experience = _context.Experiences.Find(id);
            if (experience == null)
            {
                return NotFound();
            }
            return View(experience);
        }
        [HttpPost]
        public IActionResult UpdateExperience(Experience experience)
        {
            if (ModelState.IsValid)
            {
                _context.Experiences.Update(experience);
                _context.SaveChanges();
                return RedirectToAction("ExperienceList");
            }
            return View(experience);
        }
    }
}
