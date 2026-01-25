using Microsoft.AspNetCore.Mvc;
using ResumeProject.Context;

namespace ResumeProject.Controllers
{
    public class DashboardController : Controller
    {
        private readonly ResumeContext _context;

        public DashboardController(ResumeContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            ViewBag.SkillCount = _context.Skills.Count();
            ViewBag.ProjectCount = _context.Portfolios.Count();
            ViewBag.ExperienceCount = _context.Experiences.Count();
            ViewBag.SocialCount = _context.Socials.Count();

            var about = _context.Abouts.FirstOrDefault();
            return View(about);
        }
    }
}