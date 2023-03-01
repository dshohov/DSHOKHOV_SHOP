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
        private readonly ICategoryRepository _categoryRepository;
        private readonly IPhotoService _photoService;
        public CategoryController(ICategoryRepository categoryRepository, IPhotoService photoService)
        {
            _categoryRepository = categoryRepository;
            _photoService = photoService;
        }

        public async Task<IActionResult> Woman()
        {
            IEnumerable<Category> categories = await _categoryRepository.GetCategory(People.Women);
            return View(categories);
        }
        public async Task<IActionResult> Man()
        {
            IEnumerable<Category> categories = await _categoryRepository.GetCategory(People.Men);
            return View(categories);
        }
        public async Task<IActionResult> Child()
        {
            IEnumerable<Category> categories = await _categoryRepository.GetCategory(People.Child);
            return View(categories);
        }

        public IActionResult Create()
        {
            return View("Create");
        }
            
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(CreateOrEditCategoryViewModel categoryVM)
        {
            var result = await _photoService.AddPhotoAsync(categoryVM.Image);
            var category = new Category
            {
                Name_For_User = categoryVM.Name_For_User,
                Description = categoryVM.Description,
                People = categoryVM.People,
                Image = result.Url.ToString(),
            };
            _categoryRepository.Add(category);
            return RedirectToAction("Woman");
        }
        
        public async Task<IActionResult> Edit(int id)
        {
            var category = await _categoryRepository.GetByIdAsync(id);
            var categoryVM = new CreateOrEditCategoryViewModel
            {
                Name_For_User = category.Name_For_User,
                Description = category.Description,
                URL = category.Image,
                People = category.People
            };
            return View(categoryVM);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id,CreateOrEditCategoryViewModel categoryVM)
        {
            var editCategory = await _categoryRepository.GetByIdAsyncNoTracking(id);

            if(editCategory != null)
            {
                try
                {
                    await _photoService.DeletePhotoAsync(editCategory.Image);
                }
                catch(Exception ex)
                {
                    ModelState.AddModelError("", "Could not delete photo");
                    return View(categoryVM);
                }
                if(categoryVM.Image != null)
                {
                    var photoResult = await _photoService.AddPhotoAsync(categoryVM.Image);

                    var category = new Category
                    {
                        Id = id,
                        Name_For_User = categoryVM.Name_For_User,
                        Description = categoryVM.Description,
                        People = categoryVM.People,
                        Image = photoResult.Url.ToString()
                    };
                    _categoryRepository.Update(category);
                }
                else
                {
                    var category = new Category
                    {
                        Id = id,
                        Name_For_User = categoryVM.Name_For_User,
                        Description = categoryVM.Description,
                        People = categoryVM.People,
                        Image = editCategory.Image
                    };
                    _categoryRepository.Update(category);
                }

                switch ((categoryVM.People)
)
                {
                    case People.Men:
                        return RedirectToAction("Man");
                    case People.Women:
                        return RedirectToAction("Woman");
                    case People.Child:
                        return RedirectToAction("Child");
                    default:
                        break;
                }

                return RedirectToAction("Woman");
            }
            return View(categoryVM);
        }
    }
}
