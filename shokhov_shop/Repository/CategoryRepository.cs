using CloudinaryDotNet.Actions;
using Google.Cloud.Translation.V2;
using Microsoft.EntityFrameworkCore;
using shokhov_shop.Data;
using shokhov_shop.Data.Enum;
using shokhov_shop.Intefaces;
using shokhov_shop.Models;
using shokhov_shop.ViewModels;
using System.Collections;
using System.Resources;

namespace shokhov_shop.Repository
{
    public class CategoryRepository : ICategoryRepository
    {
        private readonly ApplicationDbContext context;
        private readonly IConfiguration _config;
        public CategoryRepository(ApplicationDbContext context, IConfiguration config)
        {
            this.context = context;
            _config = config;
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

        public async Task<string> TranslateWordAsync(string word)
        {
            string textToTranslate = word;
            string targetLanguage = "en"; // English
            var moviesApiKey = _config["TranslationApiKey"];
            TranslationClient client = TranslationClient.CreateFromApiKey(moviesApiKey);
            var response = await client.TranslateTextAsync(textToTranslate, targetLanguage);
            return response.TranslatedText;
        }
        public void WriteToResources(string uaWord, string enWord, People people)
        {
            var resxFilePath = "Resources\\Views\\Category\\Woman.en.resx";
            switch (people)
            {
                case People.Men:
                    resxFilePath = "Resources\\Views\\Category\\Man.en.resx";
                    break;
                case People.Women:
                    resxFilePath = "Resources\\Views\\Category\\Woman.en.resx";
                    break;
                case People.Child:
                    resxFilePath = "Resources\\Views\\Category\\Child.en.resx";
                    break;
            }
            

            // Создаем экземпляр ResXResourceReader для чтения существующих ресурсов
            using (var resxReader = new ResXResourceReader(resxFilePath))
            {
                // Создаем экземпляр ResXResourceWriter для записи обновленного файла ресурсов
                using (var resxWriter = new System.Resources.ResXResourceWriter(resxFilePath))
                {
                    // Копируем существующие ресурсы в ResXResourceWriter
                    foreach (DictionaryEntry resource in resxReader)
                    {
                        resxWriter.AddResource(resource.Key.ToString(), resource.Value);
                    }

                    // Добавляем новые ресурсы в ResXResourceWriter
                    resxWriter.AddResource(uaWord, enWord);
                }
            }
        }
        
        
    }
}
