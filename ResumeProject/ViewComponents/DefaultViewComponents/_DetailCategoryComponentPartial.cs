using Microsoft.AspNetCore.Mvc;
using ResumeProject.Context;

namespace ResumeProject.ViewComponents.DefaultViewComponents
{
    public class _DetailCategoryComponentPartial :ViewComponent
    {
        private readonly ResumeContext _concext;

        public _DetailCategoryComponentPartial(ResumeContext concext)
        {
            _concext = concext;
        }

        public IViewComponentResult Invoke()
        {
            var values = _concext.Categories.ToList();
            return View(values);
        }
    }
}
