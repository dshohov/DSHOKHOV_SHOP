using Search_WebApi.Data;
using Search_WebApi.Interface;
using Search_WebApi.Models;

namespace Search_WebApi.Repository
{
    public class ProductRepository : IProductRepository
    {
        private readonly DataContext _context;
        public ProductRepository(DataContext context)
        {
            _context = context;
        }

        public IEnumerable<Product> GetProductBySearchTerm(string searchTerm)
        {
            return _context.Products.Where(p => p.Name_For_User.Contains(searchTerm) || p.Description.Contains(searchTerm));
        }

        public IEnumerable<Product> GetProducts()
        {
            return _context.Products.ToList();
        }
    }
}
