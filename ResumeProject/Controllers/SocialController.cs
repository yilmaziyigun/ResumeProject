using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using ResumeProject.Context;

namespace ResumeProject.Controllers
{
    public class SocialController : Controller
    {
        private readonly ResumeContext _context;
        public IActionResult Index()
        {
            var socials = _context.Socials.ToList();

            ViewBag.TotalCount = socials.Count;
            ViewBag.ActiveCount = socials.Count(x => x.IsActive);
            ViewBag.PassiveCount = socials.Count(x => !x.IsActive);

            return View(socials);
        }
    }
}
