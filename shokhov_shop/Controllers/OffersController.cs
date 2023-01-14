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
            var result2 = await photoService.AddPhotoAsync(productVM.Image2);
            var result3 = await photoService.AddPhotoAsync(productVM.Image3);
            var result4 = await photoService.AddPhotoAsync(productVM.Image4);
            var result5 = await photoService.AddPhotoAsync(productVM.Image5);
            var product = new Product
            {
                Name_For_User = productVM.Name_For_User,
                Description = productVM.Description,
                People = productVM.People,
                Image = result.Url.ToString(),
                Image2 = result2.Url.ToString(),
                Image3 = result3.Url.ToString(),
                Image4 = result4.Url.ToString(),
                Image5 = result5.Url.ToString(),
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
                    await photoService.DeletePhotoAsync(editProduct.Image2);
                    await photoService.DeletePhotoAsync(editProduct.Image3);
                    await photoService.DeletePhotoAsync(editProduct.Image4);
                    await photoService.DeletePhotoAsync(editProduct.Image5);
                }
                catch (Exception ex)
                {
                    ModelState.AddModelError("", "Could not delete photo");
                    return View(productVM);
                }
                if ((productVM.Image != null) && (productVM.Image2 != null) && (productVM.Image3 != null) && (productVM.Image4 != null) && (productVM.Image5 != null))
                {
                    var photoResult = await photoService.AddPhotoAsync(productVM.Image);
                    var photoResult2 = await photoService.AddPhotoAsync(productVM.Image2);
                    var photoResult3 = await photoService.AddPhotoAsync(productVM.Image3);
                    var photoResult4 = await photoService.AddPhotoAsync(productVM.Image4);
                    var photoResult5 = await photoService.AddPhotoAsync(productVM.Image5);
                    var product = new Product
                    {
                        Id = id,
                        Name_For_User = productVM.Name_For_User,
                        Description = productVM.Description,
                        People = productVM.People,
                        Image = photoResult.Url.ToString(),
                        Image2 = photoResult2.Url.ToString(),
                        Image3 = photoResult3.Url.ToString(),
                        Image4 = photoResult4.Url.ToString(),
                        Image5 = photoResult5.Url.ToString(),
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
                        Image = editProduct.Image,
                        Image2 = editProduct.Image2,
                        Image3 = editProduct.Image3,
                        Image4 = editProduct.Image4,
                        Image5 = editProduct.Image5
                       
                    };
                    productRepository.Update(product);
                }

                switch ((productVM.People)
)
                {
                    case People.Men:
                        return RedirectToAction("Man", "Category");
                    case People.Women:
                        return RedirectToAction("Woman", "Category");
                    case People.Child:
                        return RedirectToAction("Child", "Category");
                    default:
                        break;
                }

                return RedirectToAction("Woman", "Category");
            }
            return View(productVM);
        }
    }
}
