using Microsoft.EntityFrameworkCore;
using shokhov_shop.Data;
using shokhov_shop.Intefaces;
using shokhov_shop.Models;
using System.Linq;

namespace shokhov_shop.Repository
{
    public class ProductRepository : IProductRepository
    {
        private readonly ApplicationDbContext context;
        public ProductRepository(ApplicationDbContext context)
        {
            this.context = context;
        }
        public bool Add(Product product)
        {
            this.context.Add(product);
            return Save();
        }

        public bool Delete(Product product)
        {
            context.Remove(product);
            return Save();
        }

        public async Task<IEnumerable<Product>> GetAllProduct()
        {
            return await context.Products.ToListAsync();
        }

        public async Task<IEnumerable<Product>> GetAllProductInCategory(int id)
        {
            return await context.Products.Where(x => x.Category_id == id).ToListAsync();
        }

        public async Task<Product> GetByIdAsync(int id)
        {
            return await context.Products.FirstOrDefaultAsync(i => i.Id == id);
        }

        public async Task<Product> GetByIdAsyncNoTracking(int id)
        {
            return await context.Products.AsNoTracking().FirstOrDefaultAsync(i => i.Id == id);
        }

        public string GetNameCategory(int id)
        {
            var a = context.Categories.FirstOrDefault(c => c.Id == id);
            return a.Name_For_User;
        }

        public bool Save()
        {
            var saved = this.context.SaveChanges();
            return saved > 0 ? true : false;
        }
        public bool Update(Product product)
        {
            this.context.Update(product);
            return Save();
        }

        public async Task<IEnumerable<Product>> UseFilters(string sub_category, int categoryId)
        {
            return await context.Products.Where(i => i.Category_id == categoryId).Where(i => i.Sub_category == sub_category).ToListAsync();
        }
        public async Task<Product> GetProduct(int id)
        {
            return await context.Products.Where(i => i.Id == id).FirstAsync();
        }
    }
}
