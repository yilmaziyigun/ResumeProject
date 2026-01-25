using Microsoft.AspNetCore.Mvc;
using ResumeProject.Context;

namespace ResumeProject.ViewComponents.DefaultViewComponents
{
    public class _DefaultExperienceComponentPartial : ViewComponent
    {
        private readonly ResumeContext _context;

        public _DefaultExperienceComponentPartial(ResumeContext context)
        {
            _context = context;
        }

        public IViewComponentResult Invoke()
        {
            ViewBag.Educations = _context.Educations
                .OrderByDescending(x => x.EducationId)
                .ToList();

            ViewBag.Experiences = _context.Experiences
                .OrderByDescending(x => x.ExperienceId)
                .ToList();

            return View();
        }
    }
}
