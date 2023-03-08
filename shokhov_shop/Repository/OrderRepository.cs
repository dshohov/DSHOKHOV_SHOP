using LiqPay.SDK;
using LiqPay.SDK.Dto;
using LiqPay.SDK.Dto.Enums;
using Microsoft.EntityFrameworkCore;
using shokhov_shop.Data;
using shokhov_shop.Interfaces;
using shokhov_shop.Models;

namespace shokhov_shop.Repository
{
    public class OrderRepository : IOrderRepository
    {
        private readonly ApplicationDbContext _context;
        private readonly IConfiguration _config;
        public OrderRepository(ApplicationDbContext context, IConfiguration config)
        {
            _context = context;
            _config = config;
        }
        public bool Add(Order order)
        {
            _context.Add(order);
            return Save();
        }

        public async Task Add_Product(Order order, Set_Product set_Product)
        {   
            set_Product.Order= order;
            Product product = await _context.Products.FirstOrDefaultAsync(p => p.Id==set_Product.Id_Product);
            set_Product.Price = product.Price;
            set_Product.Name = product.Name_For_User;
            set_Product.Image = product.Image;
            _context.Add(set_Product);
            Save();
            
        }
        public void Confirm_Order(Order order)
        {
            order.Is_Approved = true;
        }

        public List<Set_Product> GetSet_Products(Order order)
        {
            return _context.Set_Products.Where(i => i.Order == order).ToList();
        }

        public async Task<IEnumerable<Order>> Get_isAproved_Orders()
        {
            return await _context.Orders.Where(i => i.Is_Approved == true).ToListAsync();
        }

        public async Task<bool> Remove_Product(Order order,int id)
        {
            var set_Product = await _context.Set_Products.FirstOrDefaultAsync(p => p.Id==id);
            order.Set_Products.Remove(set_Product);
            _context.Remove(set_Product);
            return Save();
        }

        public bool Save()
        {
            var saved = _context.SaveChanges();
            return saved > 0 ? true : false;
        }

        public async Task<Order> Search_Order_Id(int id)
        {
            return await _context.Orders.Where(i => i.Id == id).FirstOrDefaultAsync();
        }

        public async Task<Order> Search_Order_User_Not_Confirm(AppUser user)
        {
            return await _context.Orders.Where(i => i.User == user && i.Is_Approved == false).FirstOrDefaultAsync();
        }

        public async Task Send_PayForm(Order old_order)
        {
            var list_prod_for_check = new List<LiqPayRequestGoods>() { };
            foreach (Set_Product item in old_order.Set_Products)
            {
                var set_prod_for_check = new LiqPayRequestGoods() { Amount = (double)item.Price, Count = 1, Name = item.Name, Unit = "шт." };
                list_prod_for_check.Add(set_prod_for_check);
            }
            // send invoce by email
            var invoiceRequest = new LiqPayRequest
            {
                Email = old_order.User.Email,
                Amount = (double)old_order.Total_Price,
                Currency = "UAH",
                OrderId = old_order.Id.ToString(),
                Action = LiqPayRequestAction.InvoiceSend,
                Language = LiqPayRequestLanguage.UK,
                Goods = list_prod_for_check

            };

            var a = _config["Liqpay_public"];
            var b = _config["Liqpay_private"];
            var liqPayClient = new LiqPayClient(a, b);
            //liqPayClient.IsCnbSandbox = true;
            var response = await liqPayClient.RequestAsync("request", invoiceRequest);
        }

        public decimal TotalPrice(Order order)
        {
            return order.Set_Products.Sum(i => i.Price);
        }

        public bool Update(Order order)
        {
            _context.Update(order);
            return Save();
        }

        public async Task<Order> Update_Old_Order(Order old_order, Order order)
        {
            await Task.Run(() =>
            {
                old_order.Number_Post = order.Number_Post;
                old_order.Comment = order.Comment;
                old_order.Full_Name = order.Full_Name;
                old_order.Telefon = order.Telefon;
                old_order.City = order.City;
                old_order.Set_Products = GetSet_Products(old_order);
                old_order.Total_Price = TotalPrice(old_order);
                old_order.Is_Approved = true;
                old_order.Completed = false;
                old_order.Confirmed_Admin = false;
            });
            
            return old_order;
        }
    }
}
