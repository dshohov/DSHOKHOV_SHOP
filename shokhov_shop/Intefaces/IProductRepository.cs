using shokhov_shop.Models;

namespace shokhov_shop.Intefaces
{
    public interface IProductRepository
    {
        Task<IEnumerable<Product>> GetAllProduct();
        Task<IEnumerable<Product>> GetAllProductInCategory(int id);
        Task<IEnumerable<Product>> UseFilters(string sub_category, int categoryId);
        Task<Product> GetByIdAsyncNoTracking(int id);
        Task<Product> GetByIdAsync(int id);
        bool Add(Product product);
        bool Delete(Product product);
        bool Update(Product product);
        bool Save();
    }
}
