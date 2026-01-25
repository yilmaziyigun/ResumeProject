using Microsoft.AspNetCore.Mvc;
using ResumeProject.Context;

namespace ResumeProject.ViewComponents
{
    public class DetailNotificationViewComponent : ViewComponent
    {
        private readonly ResumeContext _context;

        public DetailNotificationViewComponent(ResumeContext context)
        {
            _context = context;
        }

        public IViewComponentResult Invoke()
        {
            int unreadCount = _context.Messages.Count(x => !x.IsRead);
            return View(unreadCount);
        }
    }


}
