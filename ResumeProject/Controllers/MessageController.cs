using Microsoft.AspNetCore.Mvc;
using ResumeProject.Context;
using ResumeProject.Entities;

namespace ResumeProject.Controllers
{
    public class MessageController : Controller
    {
        private readonly ResumeContext _context;

        public MessageController(ResumeContext context)
        {
            _context = context;
        }

        public IActionResult MessageList()
        {
            ViewBag.UnreadCount = _context.Messages.Count(x => !x.IsRead);
            var messages = _context.Messages.ToList();
            return View(messages);
        }
        public IActionResult DeleteMessage(int id)
        {
            ViewBag.UnreadCount = _context.Messages.Count(x => !x.IsRead);
            var message = _context.Messages.Find(id);
            if (message != null)
            {
                _context.Messages.Remove(message);
                _context.SaveChanges();
            }
            return RedirectToAction("MessageList");
        }
        public IActionResult Detail(int id)
        {
            var message = _context.Messages.FirstOrDefault(x => x.MessageId == id);

            if (message == null)
                return NotFound();

            // Okundu olarak işaretle
            if (!message.IsRead)
            {
                message.IsRead = true;
                _context.SaveChanges();
            }
            ViewBag.UnreadCount = _context.Messages.Count(x => !x.IsRead);

            return View(message);
        }
        public IActionResult DetailUnRead(int id)
        {
            var message = _context.Messages.FirstOrDefault(x => x.MessageId == id);

            if (message == null)
                return NotFound();

            // Okundu olarak işaretle
            if (!message.IsRead)
            {
                message.IsRead = true;
                _context.SaveChanges();
            }
            ViewBag.UnreadCount = _context.Messages.Count(x => !x.IsRead);

            return View(message);
        }
        public IActionResult UnreadMessages()
        {
            var messages = _context.Messages
                .Where(x => !x.IsRead)
                .OrderByDescending(x => x.SendDate)
                .ToList();

            return View(messages);
        }
        public IActionResult OkunmadıYap(int id)
        {
            var message = _context.Messages.FirstOrDefault(x => x.MessageId == id);

            if (message == null)
                return NotFound();

            // Okundu olarak işaretle
            if (message.IsRead)
            {
                message.IsRead = false;
                _context.SaveChanges();
            }
            ViewBag.UnreadCount = _context.Messages.Count(x => !x.IsRead);

            return View(message);
        }
        [HttpPost]
        public IActionResult SendMessage(Message model)
        {
            if (!ModelState.IsValid)
                return RedirectToAction("Index", "Default"); // veya Contact

            model.SendDate = DateTime.Now;
            model.IsRead = false;

            _context.Messages.Add(model);
            _context.SaveChanges();

            TempData["success"] = "Mesajınız başarıyla gönderildi.";
            return RedirectToAction("Index", "Default"); // formun olduğu sayfa
        }

    }
}
