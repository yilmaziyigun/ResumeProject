using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using ResumeProject.Context;

namespace ResumeProject.ViewComponents.DefaultViewComponents
{
    public class _DefaultAboutComponentPartial : ViewComponent
    {
        private readonly ResumeContext _context;

        public _DefaultAboutComponentPartial(ResumeContext context)
        {
            _context = context;
        }

        public IViewComponentResult Invoke()
        {
            var about = _context.Abouts
        .Include(x => x.Skills)
        .FirstOrDefault();
            ViewData["PortfolioCount"] = _context.Portfolios.Count();
            ViewData["SkillsCount"] = _context.Skills.Count();
            var portfolioCount = _context.Portfolios.Count();

            ViewBag.PortfolioCount = portfolioCount;
            ViewBag.CoffeeCount = portfolioCount * 10;
            ViewBag.EkipArk = portfolioCount * 5;
            return View(about);
        }
    }
}
