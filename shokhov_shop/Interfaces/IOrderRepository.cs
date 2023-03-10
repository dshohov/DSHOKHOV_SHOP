using shokhov_shop.Models;

namespace shokhov_shop.Interfaces
{
    public interface IOrderRepository
    {
        List<Set_Product> GetSet_Products(Order order);
        Task<IEnumerable<Order>> Get_isAproved_Orders();
        Task<Order> Search_Order_Id (int id);
        Task<Order> Search_Order_User_Not_Confirm(AppUser user);
        Task<Order> Update_Old_Order(Order old_order, Order order);
        decimal TotalPrice(Order order);
        void Confirm_Order (Order order);
        Task Add_Product(Order order, Set_Product set_Product);
        Task<bool> Remove_Product(Order order,int id);
        Task Send_PayForm(Order old_order);
        bool Add(Order order);
        bool Update(Order order);
        bool Save();
    }
}
