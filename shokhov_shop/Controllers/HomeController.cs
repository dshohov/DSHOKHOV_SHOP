using shokhov_shop.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using shokhov_shop.Services;
using shokhov_shop.Data;
using shokhov_shop.Interfaces;
using Microsoft.AspNetCore.Localization;
using LiqPay.SDK.Dto;
using LiqPay.SDK.Dto.Enums;
using LiqPay.SDK;

namespace shokhov_shop.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly IChatHistoryRepository _chatHistoryRepository;
        private readonly IConfiguration _config;
        public HomeController(ILogger<HomeController> logger, IChatHistoryRepository chatHistoryRepository, IConfiguration config)
        {
            _logger = logger;
            _chatHistoryRepository = chatHistoryRepository;
            _config = config;
        }

        public async Task<IActionResult> Index()
        {
            // send invoce by email
            var invoiceRequest = new LiqPayRequest
            {
                Email = "dshohov@gmail.com",
                Amount = 1,
                Currency = "USD",
                OrderId = "dima3",
                Action = LiqPayRequestAction.InvoiceSend,
                Language = LiqPayRequestLanguage.EN,
                Goods = new List<LiqPayRequestGoods> {
                new LiqPayRequestGoods {
                    Amount = 1,
                    Count = 2,
                    Unit = "pcs.",
                    Name = "phone"
                }
            }
                    };
            var a = _config["Liqpay_public"];
            var b = _config["Liqpay_private"];
            var liqPayClient = new LiqPayClient(a, b);
            //liqPayClient.IsCnbSandbox = true;
            var response = await liqPayClient.RequestAsync("request", invoiceRequest);
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