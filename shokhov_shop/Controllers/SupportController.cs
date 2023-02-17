using Microsoft.AspNetCore.Mvc;
using shokhov_shop.Interfaces;
using shokhov_shop.ViewModels;

namespace shokhov_shop.Controllers
{
    public class SupportController : Controller
    {
        private readonly IChatHistoryRepository _chatHistoryRepository;
        private readonly ISendGridEmail _sendGridEmail;
        public SupportController(IChatHistoryRepository chatHistoryRepository, ISendGridEmail sendGridEmail)
        {
            _chatHistoryRepository = chatHistoryRepository;
            _sendGridEmail = sendGridEmail;
        }

        public IActionResult SendMessage()
        {
            return View();
        }
        public IActionResult ChatHistory()
        {
            // Передать список сообщений в представление
            return View(_chatHistoryRepository.GetChatHistories());
        }
        [HttpPost]
        public IActionResult Delete(int messageId)
        {
            _chatHistoryRepository.Delete(_chatHistoryRepository.GetMessage(messageId));
            return RedirectToAction(nameof(ChatHistory));
        }
        public IActionResult ViewMessage(int messageId)
        {
            
            return View(_chatHistoryRepository.GetMessage(messageId));
        }
        [HttpGet]
        public IActionResult SendResponse(string emailUser)
        {
             
            return View(new SendResponseViewModel() { EmailUser = emailUser});
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> SendResponse(SendResponseViewModel sendResponseViewModel)
        {
            if (ModelState.IsValid)
            {
                await _sendGridEmail.SendEmailAsync(sendResponseViewModel.EmailUser, "Reset Email Confirmation", "Our response: " + sendResponseViewModel.Message);
                return RedirectToAction("SendMessage");
            }
            return View();
        }
        
       
    }
}
