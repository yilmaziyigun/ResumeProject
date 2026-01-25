using Microsoft.AspNetCore.Mvc;
using ResumeProject.Context;

namespace ResumeProject.ViewComponents.DefaultViewComponents
{
    public class _DefaultHomeComponentPartial : ViewComponent
    {
        private readonly ResumeContext _context;

        public _DefaultHomeComponentPartial(ResumeContext context)
        {
            _context = context;
        }

        public IViewComponentResult Invoke()
        {
            var model = _context.Socials
        .FirstOrDefault(x => x.IsActive && x.headername != null);

            ViewBag.SocialMedias = _context.Socials
                .Where(x => x.IsActive && x.Icon != null)
                .ToList();

            return View(model);
        }
    }
}
