using Microsoft.AspNetCore.Mvc;
using shokhov_shop.Data.Enum;
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
            ViewBag.Messege = productRepository.GetNameCategory(id);
            return View(products);
        }
        public async Task<IActionResult> OffersUseFilters(int id)
        {
            var product = await productRepository.GetByIdAsync(id);
            IEnumerable<Product> products = await productRepository.UseFilters(product.Sub_category, product.Category_id);
            ViewBag.Messege = productRepository.GetNameCategory(product.Category_id);
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
                Name_For_User = productVM.Name_For_User,
                Description = productVM.Description,
                People = productVM.People,
                Image = result.Url.ToString(),
                Sub_category = productVM.Sub_category,
                Category_id = productVM.Category_id,
                Price = productVM.Price
            };
            productRepository.Add(product);
            return RedirectToAction("Offers");
        }

        public async Task<IActionResult> Edit(int id)
        {
            var product = await productRepository.GetByIdAsync(id);
            var productVM = new EditProductViewModel
            {
                Name_For_User = product.Name_For_User,
                Description = product.Description,
                URL = product.Image,
                People = product.People,
                Category_id = product.Category_id,
                Price = product.Price,
                Sub_category = product.Sub_category
            };
            return View(productVM);
        }

        [HttpPost]
        public async Task<IActionResult> Edit(int id, EditProductViewModel productVM)
        {
            var editProduct = await productRepository.GetByIdAsyncNoTracking(id);

            if (editProduct != null)
            {
                try
                {
                    await photoService.DeletePhotoAsync(editProduct.Image);
                }
                catch (Exception ex)
                {
                    ModelState.AddModelError("", "Could not delete photo");
                    return View(productVM);
                }
                if (productVM.Image != null)
                {
                    var photoResult = await photoService.AddPhotoAsync(productVM.Image);

                    var product = new Product
                    {
                        Id = id,
                        Name_For_User = productVM.Name_For_User,
                        Description = productVM.Description,
                        People = productVM.People,
                        Image = photoResult.Url.ToString(),
                        Category_id = productVM.Category_id,
                        Price = productVM.Price,
                        Sub_category = productVM.Sub_category
                    };
                    productRepository.Update(product);
                }
                else
                {
                    var product = new Product
                    {
                        Id = id,
                        Name_For_User = productVM.Name_For_User,
                        Description = productVM.Description,
                        People = productVM.People,
                        Category_id = productVM.Category_id,
                        Price = productVM.Price,
                        Sub_category = productVM.Sub_category,
                        Image = editProduct.Image
                    };
                    productRepository.Update(product);
                }

                switch ((productVM.People)
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
            return View(productVM);
        }
    }
}
