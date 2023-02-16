using Microsoft.AspNetCore.Mvc;
using shokhov_shop.Interfaces;

namespace shokhov_shop.Controllers
{
    public class SupportController : Controller
    {
        private readonly IChatHistoryRepository _chatHistoryRepository;

        public SupportController(IChatHistoryRepository chatHistoryRepository)
        {
            _chatHistoryRepository = chatHistoryRepository;
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
    }
}
