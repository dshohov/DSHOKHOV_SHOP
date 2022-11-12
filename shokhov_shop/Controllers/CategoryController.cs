using Microsoft.AspNetCore.Mvc;
using shokhov_shop.Data;
using shokhov_shop.Data.Enum;
using shokhov_shop.Intefaces;
using shokhov_shop.Models;

namespace shokhov_shop.Controllers
{
    public class CategoryController : Controller
    {
        private readonly ICategoryRepository categoryRepository;
        public CategoryController(ICategoryRepository categoryRepository)
        {
            this.categoryRepository = categoryRepository;
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
    }
}
