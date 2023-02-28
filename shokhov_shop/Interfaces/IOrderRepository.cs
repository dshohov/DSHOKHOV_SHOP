using shokhov_shop.Models;

namespace shokhov_shop.Interfaces
{
    public interface IOrderRepository
    {
        List<Set_Product> GetSet_Products(Order order);
        Order Search_Order_Id (Order order);
        Order Search_Order_User_Not_Confirm(AppUser user);
        decimal TotalPrice(Order order);
        void Confirm_Order (Order order);
        void Add_Product(Order order, Set_Product set_Product);
        bool Remove_Product(Order order,int id);
        bool Add(Order order);
        bool Update(Order order);
        bool Save();
    }
}
