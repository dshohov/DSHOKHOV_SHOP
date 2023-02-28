using shokhov_shop.Data;
using shokhov_shop.Interfaces;
using shokhov_shop.Models;

namespace shokhov_shop.Repository
{
    public class OrderRepository : IOrderRepository
    {
        private readonly ApplicationDbContext _context;
        public OrderRepository(ApplicationDbContext context)
        {
            _context = context;
        }
        public bool Add(Order order)
        {
            _context.Add(order);
            return Save();
        }

        public void Add_Product(Order order, Set_Product set_Product)
        {   
            set_Product.Order= order;
            Product product = _context.Products.FirstOrDefault(p => p.Id==set_Product.Id_Product);
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

        public IEnumerable<Order> Get_isAproved_Orders()
        {
            return _context.Orders.Where(i => i.Is_Approved == true).ToList();
        }

        public bool Remove_Product(Order order,int id)
        {
            var set_Product = _context.Set_Products.FirstOrDefault(p => p.Id==id);
            order.Set_Products.Remove(set_Product);
            _context.Remove(set_Product);
            return Save();
        }

        public bool Save()
        {
            var saved = _context.SaveChanges();
            return saved > 0 ? true : false;
        }

        public Order Search_Order_Id(int id)
        {
            return _context.Orders.Where(i => i.Id == id).FirstOrDefault();
        }

        public Order Search_Order_User_Not_Confirm(AppUser user)
        {
            return _context.Orders.Where(i => i.User == user && i.Is_Approved == false).FirstOrDefault();
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
    }
}
