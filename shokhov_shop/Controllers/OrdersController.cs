using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using shokhov_shop.Interfaces;
using shokhov_shop.Models;

namespace shokhov_shop.Controllers
{
    public class OrdersController : Controller
    {
        private readonly IOrderRepository _orderRepository;
        private readonly UserManager<AppUser> _userManager;

        public OrdersController(UserManager<AppUser> userManager,IOrderRepository orderRepository)
        {
            _userManager = userManager;
            _orderRepository = orderRepository;
        }

        public async Task<IActionResult> Index()
        {
            
            AppUser user = _userManager.GetUserAsync(User).Result;
            var order = await _orderRepository.Search_Order_User_Not_Confirm(user);
            if(order == null || _orderRepository.GetSet_Products(order).Count() == 0)
            {
                TempData["MyModel"] = "Вибачте але зараз ваша корзина пуста, додайте продукти та повертайтеся для оформеня замовлення.";
                return RedirectToAction("Error_Order", "Orders");
            }
            order.Set_Products = _orderRepository.GetSet_Products(order);
            order.Total_Price = _orderRepository.TotalPrice(order);
            return View(order);
        }

        public async Task<IActionResult> Remove_Product(int id)
        {
            AppUser user = _userManager.GetUserAsync(User).Result;
            var order = await _orderRepository.Search_Order_User_Not_Confirm(user);
            await _orderRepository.Remove_Product(order, id);
            return Redirect(Request.Headers["Referer"].ToString());
        }
        [HttpPost]
        public async Task<IActionResult> Buy(Order order)
        {
            AppUser user = _userManager.GetUserAsync(User).Result;
            var old_order = await _orderRepository.Search_Order_User_Not_Confirm(user);
            old_order = await _orderRepository.Update_Old_Order(old_order, order);
            
            
            _orderRepository.Update(old_order);
            return View();
        }
        public IActionResult Confirm_Order()
        {
            return View();
        }
        
        [HttpPost]
        public async Task<IActionResult> Add_Product(Set_Product set_Product)
        {
            if (!User.Identity.IsAuthenticated)
            {
                TempData["MyModel"] = "Вибачте але ви не війшли до свого акаунту, будь-ласка зробіть це для того що зайти до корзини або додати до неї щось!";
                return RedirectToAction("Error_Order", "Orders");
            }
            AppUser user = _userManager.GetUserAsync(User).Result;
            var order = await _orderRepository.Search_Order_User_Not_Confirm(user);
            if (order == null)
            {
                order = new Order()
                {
                    User = user,
                    Is_Approved = false,
                    
                
                };
                _orderRepository.Add(order);
            }
            await _orderRepository.Add_Product(order,set_Product);
            order.Set_Products = _orderRepository.GetSet_Products(order);
            _orderRepository.Update(order);
            return Redirect(Request.Headers["Referer"].ToString());
        }
        public IActionResult Error_Order()
        {
            if (!User.Identity.IsAuthenticated)
            {
                TempData["MyModel"] = "Вибачте але ви не війшли до свого акаунту, будь-ласка зробіть це для того що зайти до корзини або додати до неї щось!";
            }
            ViewBag.Message = TempData["MyModel"] as string;
            TempData.Remove("MyModel");
            return View();
        }

        public async Task<IActionResult> Check_Order(int? varible)
        {
            var orders = await _orderRepository.Get_isAproved_Orders();
            if(varible == 1)
            {
                return View(orders.Where(i=>i.Completed == false && i.Confirmed_Admin == true).ToList());
            }
            if(varible == 2)
            {
                return View(orders.Where(i=>i.Completed == true && i.Confirmed_Admin == true).ToList());
            }
            

            return View(orders.Where(i=>i.Confirmed_Admin == false).ToList());
        }

        public async Task<IActionResult> Confirmed_Admin(int id)
        {
            var order = await _orderRepository.Search_Order_Id(id);
            order.Confirmed_Admin = true;
            _orderRepository.Update(order);
            return Redirect(Request.Headers["Referer"].ToString());
        }
        public async Task<IActionResult> Completed(int id)
        {
            var order = await _orderRepository.Search_Order_Id(id);
            order.Completed = true;
            _orderRepository.Update(order);
            return Redirect(Request.Headers["Referer"].ToString());
        }
        public async Task<IActionResult> Detail(int id)
        {
            var order = await _orderRepository.Search_Order_Id(id);
            if (order == null || _orderRepository.GetSet_Products(order).Count() == 0)
            {
                TempData["MyModel"] = "Вибачте але зараз ваша корзина пуста, додайте продукти та повертайтеся для оформеня замовлення.";
                return RedirectToAction("Error_Order", "Orders");
            }
            order.Set_Products = _orderRepository.GetSet_Products(order);
            order.Total_Price = _orderRepository.TotalPrice(order);
            return View(order);
        }
    }
}
