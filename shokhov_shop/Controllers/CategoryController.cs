using Microsoft.AspNetCore.Mvc;
using shokhov_shop.Data;
using shokhov_shop.Data.Enum;
using shokhov_shop.Intefaces;
using shokhov_shop.Models;
using shokhov_shop.ViewModels;

namespace shokhov_shop.Controllers
{
    public class CategoryController : Controller
    {
        private readonly ICategoryRepository categoryRepository;
        private readonly IPhotoService photoService;
        public CategoryController(ICategoryRepository categoryRepository, IPhotoService photoService)
        {
            this.categoryRepository = categoryRepository;
            this.photoService = photoService;
        }

        public async Task<IActionResult> Woman()
        {
            IEnumerable<Category> categories = await categoryRepository.GetCategory(People.Women);
            return View(categories);
        }
        public async Task<IActionResult> Man()
        {
            IEnumerable<Category> categories = await categoryRepository.GetCategory(People.Men);
            return View(categories);
        }
        public async Task<IActionResult> Child()
        {
            IEnumerable<Category> categories = await categoryRepository.GetCategory(People.Child);
            return View(categories);
        }

        public IActionResult Create()
        {
            return View("Create");
        }
            
        [HttpPost]
        public async Task<IActionResult> Create(CreateCategoryViewModel categoryVM)
        {
            var result = await photoService.AddPhotoAsync(categoryVM.Image1);
            var category = new Category
            {
                Name = categoryVM.Name,
                Name_For_User = categoryVM.Name_For_User,
                Description = categoryVM.Description,
                People = categoryVM.People,
                Image = result.Url.ToString(),
            };
            categoryRepository.Add(category);
            return RedirectToAction("Woman");
        }
    }
}
