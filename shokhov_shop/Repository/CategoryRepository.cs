using Microsoft.EntityFrameworkCore;
using shokhov_shop.Data;
using shokhov_shop.Data.Enum;
using shokhov_shop.Intefaces;
using shokhov_shop.Models;

namespace shokhov_shop.Repository
{
    public class CategoryRepository : ICategoryRepository
    {
        private readonly ApplicationDbContext context;
        public CategoryRepository(ApplicationDbContext context)
        {
            this.context = context;
        }

        public bool Add(Category category)
        {
            this.context.Add(category);
            return Save();
        }   

        public async Task<IEnumerable<Category>> GetCategory(People people)
        {
            switch (people)
            {
                case People.Men :
                    return await context.Categories.Where(a => a.People == People.Men).ToListAsync();
                case People.Women:
                    return await context.Categories.Where(a => a.People == People.Women).ToListAsync();
                case People.Child :
                    return await context.Categories.Where(a => a.People == People.Child).ToListAsync();
                default: throw new NotImplementedException();
            }
        }

        public async Task<Category> GetByIdAsync(int id)
        {
            return await context.Categories.FirstOrDefaultAsync(i => i.Id == id);
        }
        public async Task<Category> GetByIdAsyncNoTracking(int id)
        {
            return await context.Categories.AsNoTracking().FirstOrDefaultAsync(i => i.Id == id);
        }
        public bool Save()
        {
            var saved = this.context.SaveChanges();
            return saved > 0 ? true : false;
        }

        public bool Update(Category category)
        {
            this.context.Update(category);
            return Save();
        }

    }
}
