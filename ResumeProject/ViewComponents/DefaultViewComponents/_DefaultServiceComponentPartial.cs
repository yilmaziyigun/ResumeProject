using Microsoft.AspNetCore.Mvc;
using ResumeProject.Context;

namespace ResumeProject.ViewComponents.DefaultViewComponents
{
    public class _DefaultServiceComponentPartial : ViewComponent
    {
        private readonly ResumeContext _concext;
        public _DefaultServiceComponentPartial(ResumeContext concext)
        {
            _concext = concext;
        }
        public IViewComponentResult Invoke()
        {
            var values = _concext.Services.ToList();
            return View(values);
        }
    }
}
