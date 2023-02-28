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

        public IActionResult Index()
        {
            
            AppUser user = _userManager.GetUserAsync(User).Result;
            var order = _orderRepository.Search_Order_User_Not_Confirm(user);
            if(order == null || _orderRepository.GetSet_Products(order).Count() == 0)
            {
                TempData["MyModel"] = "Вибачте але зараз ваша корзина пуста, додайте продукти та повертайтеся для оформеня замовлення.";
                return RedirectToAction("Error_Order", "Orders");
            }
            order.Set_Products = _orderRepository.GetSet_Products(order);
            order.Total_Price = _orderRepository.TotalPrice(order);
            return View(order);
        }

        public  IActionResult Remove_Product(int id)
        {
            AppUser user = _userManager.GetUserAsync(User).Result;
            var order = _orderRepository.Search_Order_User_Not_Confirm(user);
            _orderRepository.Remove_Product(order, id);
            return Redirect(Request.Headers["Referer"].ToString());
        }
        [HttpPost]
        public IActionResult Buy(Order order)
        {
            AppUser user = _userManager.GetUserAsync(User).Result;
            var old_order = _orderRepository.Search_Order_User_Not_Confirm(user);
            old_order.Number_Post = order.Number_Post;
            old_order.Comment = order.Comment;
            old_order.Full_Name = order.Full_Name;
            old_order.Telefon = order.Telefon;
            old_order.City = order.City;
            old_order.Set_Products = _orderRepository.GetSet_Products(old_order);
            old_order.Total_Price = _orderRepository.TotalPrice(old_order);
            old_order.Is_Approved = true;
            old_order.Completed = false;
            old_order.Confirmed_Admin = false;
            _orderRepository.Update(old_order);
            return View();
        }
        public IActionResult Confirm_Order()
        {
            return View();
        }
        
        [HttpPost]
        public IActionResult Add_Product(Set_Product set_Product)
        {
            if (!User.Identity.IsAuthenticated)
            {
                TempData["MyModel"] = "Вибачте але ви не війшли до свого акаунту, будь-ласка зробіть це для того що зайти до корзини або додати до неї щось!";
                return RedirectToAction("Error_Order", "Orders");
            }
            AppUser user = _userManager.GetUserAsync(User).Result;
            var order = _orderRepository.Search_Order_User_Not_Confirm(user);
            if (order == null)
            {
                order = new Order()
                {
                    User = user,
                    Is_Approved = false,
                    
                
                };
                _orderRepository.Add(order);
            }
            _orderRepository.Add_Product(order,set_Product);
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

        public IActionResult Check_Order(int? varible)
        {
            var orders = _orderRepository.Get_isAproved_Orders();
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

        public IActionResult Confirmed_Admin(int id)
        {
            var order = _orderRepository.Search_Order_Id(id);
            order.Confirmed_Admin = true;
            _orderRepository.Update(order);
            return Redirect(Request.Headers["Referer"].ToString());
        }
        public IActionResult Completed(int id)
        {
            var order = _orderRepository.Search_Order_Id(id);
            order.Completed = true;
            _orderRepository.Update(order);
            return Redirect(Request.Headers["Referer"].ToString());
        }
        public IActionResult Detail(int id)
        {
            var order = _orderRepository.Search_Order_Id(id);
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
