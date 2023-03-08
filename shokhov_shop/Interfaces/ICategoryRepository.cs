using shokhov_shop.Data.Enum;
using shokhov_shop.Models;

namespace shokhov_shop.Intefaces
{
    public interface ICategoryRepository
    {
        Task<IEnumerable<Category>> GetCategory(People people);
        Task<Category> GetByIdAsyncNoTracking(int id);
        Task<Category> GetByIdAsync(int id);
        Task<string> TranslateWordAsync(string word);
        Task WriteToResources(string uaWord, string enWord, People people);
        bool Add(Category category);
        bool Update(Category category);
        bool Save();

    }
}
