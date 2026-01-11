using Microsoft.AspNetCore.Mvc;

namespace ResumeProject.ViewComponents.DefaultViewComponents
{
    public class _DefaultHomeComponentPartial : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
