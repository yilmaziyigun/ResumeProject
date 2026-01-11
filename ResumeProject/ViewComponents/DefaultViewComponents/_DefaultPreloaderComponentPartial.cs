using Microsoft.AspNetCore.Mvc;

namespace ResumeProject.ViewComponents.DefaultViewComponents
{
    public class _DefaultPreloaderComponentPartial : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
