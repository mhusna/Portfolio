using BusinessLayer.Concrete;
using DataAccessLayer.Concrete.Repository.EfRepository;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Portfolio_Source.Areas.Writer.Models;

namespace Portfolio_Source.Areas.Writer.Controllers
{
    [Area("Writer")]
    public class MessageController : Controller
    {
        WriterMessageManager _manager = new WriterMessageManager(new EfWriterMessageRepository());
        private readonly UserManager<WriterUser> _userManager;

        public MessageController(UserManager<WriterUser> userManager)
        {
            _userManager = userManager;
        }

        public async Task<IActionResult> InboxMessages()
        {
            var user = await _userManager.FindByNameAsync(User.Identity.Name);
            var messageList = _manager.InBoxMessages(user.Email);
            return View(messageList);
        }

        public async Task<IActionResult> OutboxMessages()
        {
            var user = await _userManager.FindByNameAsync(User.Identity.Name);
            var messageList = _manager.OutBoxMessages(user.Email);
            return View(messageList);
        }

        [HttpGet]
        public IActionResult MessageDetails(int id)
        {
            WriterMessage message = _manager.TGetById(id);

            SenderReceiverViewModel model = new SenderReceiverViewModel();
            model.SentMessages = _manager.GetAllMessages(message.Receiver, message.Sender);
            model.ReceivedMessages = _manager.GetAllMessages(message.Sender, message.Receiver);

            return View(model);
        }
    }
}
