using Microsoft.AspNetCore.Mvc;
using ResumeProject.Context;

namespace ResumeProject.ViewComponents.DefaultViewComponents
{
    public class _DefaultPreloaderComponentPartial : ViewComponent
    {
        private readonly ResumeContext _concext;

        public _DefaultPreloaderComponentPartial(ResumeContext concext)
        {
            _concext = concext;
        }

        public IViewComponentResult Invoke()
        {
            var values = _concext.Educations.ToList();
            return View(values);
        }
    }
}
