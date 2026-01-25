using Microsoft.AspNetCore.Mvc;
using ResumeProject.Context;
using ResumeProject.Entities;

namespace ResumeProject.Controllers
{
    public class AboutMeController : Controller
    {
        private readonly ResumeContext _context;

        public AboutMeController(ResumeContext context)
        {
            _context = context;
        }

        public IActionResult AboutMe()
        {
            var values = _context.Abouts.ToList();
            return View(values);
        }
        public IActionResult DeleteAbout(int id)
        {
            var value = _context.Abouts.Find(id);
            _context.Abouts.Remove(value);
            _context.SaveChanges();
            return RedirectToAction("AboutMe");
        }
        public IActionResult UpdateAbout(int id)
        {
            var about = _context.Abouts.Find(id);
            if (about == null)
                return NotFound();
            return View(about);
        }

        // POST: Form submit
        [HttpPost]
        public IActionResult UpdateAbout(About model)
        {
            if (!ModelState.IsValid)
                return View(model);

            var about = _context.Abouts.Find(model.AboutId);
            if (about == null)
                return NotFound();

            // Alanları güncelle
            about.NameSurname = model.NameSurname;
            about.Description = model.Description;
            about.ImageUrl = model.ImageUrl; // Boş olabilir

            _context.SaveChanges();

            return RedirectToAction("AboutMe");
        }
        [HttpGet]
        public IActionResult CreateAbout()
        {
            return View();
        }
        [HttpPost]
        public IActionResult CreateAbout(About about)
        {
            _context.Abouts.Add(about);
            _context.SaveChanges();
            return RedirectToAction("AboutMe");
        }
       
        

    }
}
