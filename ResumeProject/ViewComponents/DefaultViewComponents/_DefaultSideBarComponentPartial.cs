using Microsoft.AspNetCore.Mvc;

namespace ResumeProject.ViewComponents.DefaultViewComponents
{
    public class _DefaultSideBarComponentPartial : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
