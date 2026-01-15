using Microsoft.AspNetCore.Mvc;
using ResumeProject.Context;

namespace ResumeProject.ViewComponents.DefaultViewComponents
{
    public class _DefaultTestimonialComponentPartial : ViewComponent
    {
        private readonly ResumeContext _concext;

        public _DefaultTestimonialComponentPartial(ResumeContext concext)
        {
            _concext = concext;
        }

        public IViewComponentResult Invoke()
        {
            var values = _concext.Testimonials.ToList();
            return View(values);
        }
    }
}
