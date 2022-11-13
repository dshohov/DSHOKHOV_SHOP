using shokhov_shop.Data.Enum;
using shokhov_shop.Models;
using shokhov_shop.ViewModels;

namespace shokhov_shop.Intefaces
{
    public interface ICategoryRepository
    {
        Task<IEnumerable<Category>> GetCategory(People people);
        Task<Category> GetByIdAsyncNoTracking(int id);
        Task<Category> GetByIdAsync(int id);
        bool Add(Category category);
        bool Update(Category category);
        bool Save();

    }
}
