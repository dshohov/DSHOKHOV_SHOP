using CloudinaryDotNet.Actions;
using shokhov_shop.Models;
using shokhov_shop.ViewModels;

namespace shokhov_shop.Intefaces
{
    public interface IProductRepository
    {
        Task<Product> GetByIdAsync(int id);
        Task<Product> GetByIdAsyncNoTracking(int id);
        Task<IEnumerable<Product>> GetAllProduct();
        Task<IEnumerable<Product>> GetAllProductInCategory(int id);
        Task<IEnumerable<Product>> UseFilters(string sub_category, int categoryId);
        string GetNameCategory(int id);
        Task WriteToResources(string[] uaWord, string[] enWord, string[] path);
        Task<string> TranslateWordAsync(string word);
        Task<Product> GetProduct(int id);
        Task<Product> Create_ProductAsync(CreateOrEditProductViewModel productVM);
        void Delete_All_Photo_Async(Product edit_Product);
        Task<Product> Update_All_Photo_Async(int id, CreateOrEditProductViewModel productVM);
        Product NoUpdate_Photo(int id, CreateOrEditProductViewModel productVM, Product editProduct);
        bool Add(Product product);
        bool Delete(Product product);
        bool Update(Product product);
        bool Save();
    }
}
