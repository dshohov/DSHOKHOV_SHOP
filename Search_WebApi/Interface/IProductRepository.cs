using Search_WebApi.Models;

namespace Search_WebApi.Interface
{
    public interface IProductRepository
    {
        IEnumerable<Product> GetProducts();
        IEnumerable<Product> GetProductBySearchTerm(string searchTerm);
    }
}
