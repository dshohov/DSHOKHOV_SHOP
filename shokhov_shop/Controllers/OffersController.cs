using Microsoft.AspNetCore.Mvc;
using shokhov_shop.Intefaces;
using shokhov_shop.Models;
using shokhov_shop.ViewModels;

namespace shokhov_shop.Controllers
{
    public class OffersController : Controller
    {
        private readonly IProductRepository productRepository;
        private readonly IPhotoService photoService;
        public OffersController(IProductRepository productRepository, IPhotoService photoService)
        {
            this.productRepository = productRepository;
            this.photoService = photoService;
        }
        public async Task<IActionResult> Offers(int id)
        {
            IEnumerable<Product> products = await productRepository.GetAllProductInCategory(id);
            return View(products);
        }
        public async Task<IActionResult> OffersUseFilters(int id)
        {
            var product = await productRepository.GetByIdAsync(id);
            IEnumerable<Product> products = await productRepository.UseFilters(product.Sub_category, product.Category_id); 
            return View(products);
        }
        public IActionResult Create()
        {
            return View("Create");
        }
        [HttpPost]
        public async Task<IActionResult> Create(CreateProductViewModel productVM)
        {
            var result = await photoService.AddPhotoAsync(productVM.Image);
            var product = new Product
            {
                Name = productVM.Name,
                Name_For_User = productVM.Name_For_User,
                Description = productVM.Description,
                People = productVM.People,
                Image = result.Url.ToString(),
                Sub_category = productVM.Sub_category,
                Category = productVM.Category,
                Category_id = productVM.Category_id,
                Price = productVM.Price
            };
            productRepository.Add(product);
            return RedirectToAction("Offers");
        }
    }
}
