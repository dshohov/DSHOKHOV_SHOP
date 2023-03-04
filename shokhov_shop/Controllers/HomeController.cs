using shokhov_shop.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using shokhov_shop.Services;
using shokhov_shop.Data;
using shokhov_shop.Interfaces;
using Microsoft.AspNetCore.Localization;

namespace shokhov_shop.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly IChatHistoryRepository _chatHistoryRepository;

        public HomeController(ILogger<HomeController> logger, IChatHistoryRepository chatHistoryRepository )
        {
            _logger = logger;
            _chatHistoryRepository = chatHistoryRepository;
        }

        public IActionResult Index()
        {
            return View();
        }
        public IActionResult ChatHistory()
        {
            // Передать список сообщений в представление
            return View(_chatHistoryRepository.GetChatHistories());
        }
        public IActionResult Privacy()
        {
            return View();
        }
        [HttpPost]
        public IActionResult CultureManager(string culture)
        {
            Response.Cookies.Append(CookieRequestCultureProvider.DefaultCookieName, CookieRequestCultureProvider.MakeCookieValue(new RequestCulture(culture)),
                new CookieOptions { Expires = DateTimeOffset.Now.AddDays(30) });
            return Redirect(Request.Headers["Referer"].ToString());
        }
        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}