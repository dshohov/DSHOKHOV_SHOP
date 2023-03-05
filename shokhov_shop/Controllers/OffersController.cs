using Microsoft.AspNetCore.Mvc;
using Polly;
using Polly.Timeout;
using shokhov_shop.Data.Enum;
using shokhov_shop.Intefaces;
using shokhov_shop.Models;
using shokhov_shop.ViewModels;
using System.Net.Http;

namespace shokhov_shop.Controllers
{
    public class OffersController : Controller
    {
        private readonly HttpClient _httpClient;
        private readonly IProductRepository _productRepository;
        private readonly IPhotoService _photoService;
        public OffersController(IProductRepository productRepository, IPhotoService photoService)
        {
            _productRepository = productRepository;
            _photoService = photoService;
            _httpClient = new HttpClient();
        }
        public async Task<IActionResult> Offers(int id)
        {
            IEnumerable<Product> products = await _productRepository.GetAllProductInCategory(id);
            ViewBag.Messege = _productRepository.GetNameCategory(id);
            return View(products);
        }
        public async Task<IActionResult> OffersUseFilters(int id)
        {
            var product = await _productRepository.GetByIdAsync(id);
            IEnumerable<Product> products = await _productRepository.UseFilters(product.Sub_category, product.Category_id);
            ViewBag.Messege = _productRepository.GetNameCategory(product.Category_id);
            return View(products);
        }
        public IActionResult Create()
        {
            return View("Create");
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(CreateOrEditProductViewModel productVM)
        {
            var product = await _productRepository.Create_ProductAsync(productVM);
            string[] uaWords = new string[] { product.Name_For_User,product.Description,product.Sub_category,_productRepository.GetNameCategory(product.Category_id) };
            string[] enWord = new string[] {
                await _productRepository.TranslateWordAsync(uaWords[0]),
                await _productRepository.TranslateWordAsync(uaWords[1]),
                await _productRepository.TranslateWordAsync(uaWords[2]),
                await _productRepository.TranslateWordAsync(uaWords[3]),
            };
            string[] paths = new string[] {
                "Resources\\Views\\Offers\\Offers.en.resx",
                "Resources\\Views\\Offers\\OffersUseFilters.en.resx",
                "Resources\\Views\\Offers\\Search.en.resx",
                "Resources\\Views\\Orders\\Index.en.resx",
                "Resources\\Views\\Product\\Index.en.resx"
            };
            await _productRepository.WriteToResources(uaWords, enWord, paths);
            _productRepository.Add(product);
            return RedirectToAction("Offers");
        }

        public async Task<IActionResult> Edit(int id)
        {
            var product = await _productRepository.GetByIdAsync(id);
            var productVM = new CreateOrEditProductViewModel
            {
                Name_For_User = product.Name_For_User,
                Description = product.Description,
                URL = product.Image,
                People = product.People,
                Category_id = product.Category_id,
                Price = product.Price,
                Sub_category = product.Sub_category,
                Sizes_Array = product.Sizes.Split(",")
                
            };
            return View(productVM);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, CreateOrEditProductViewModel productVM)
        {
            var editProduct = await _productRepository.GetByIdAsyncNoTracking(id);

            if (editProduct != null)
            {
                try
                {
                    _productRepository.Delete_All_Photo_Async(editProduct);
                }
                catch (Exception ex)
                {
                    ModelState.AddModelError("", "Could not delete photo");
                    return View(productVM);
                }
                if ((productVM.Image != null) && (productVM.Image2 != null) && (productVM.Image3 != null) && (productVM.Image4 != null) && (productVM.Image5 != null))
                {
                    var product = await _productRepository.Update_All_Photo_Async(id, productVM);
                    string[] uaWords = new string[] { product.Name_For_User, product.Description, product.Sub_category, _productRepository.GetNameCategory(product.Category_id) };
                    string[] enWord = new string[] {
                        await _productRepository.TranslateWordAsync(uaWords[0]),
                        await _productRepository.TranslateWordAsync(uaWords[1]),
                        await _productRepository.TranslateWordAsync(uaWords[2]),
                        await _productRepository.TranslateWordAsync(uaWords[3]),
                    };
                            string[] paths = new string[] {
                        "Resources\\Views\\Offers\\Offers.en.resx",
                        "Resources\\Views\\Offers\\OffersUseFilters.en.resx",
                        "Resources\\Views\\Offers\\Search.en.resx",
                        "Resources\\Views\\Orders\\Index.en.resx",
                        "Resources\\Views\\Product\\Index.en.resx"
                    };
                    await _productRepository.WriteToResources(uaWords, enWord, paths);
                    _productRepository.Update(product);
                }
                else
                {
                    var product = _productRepository.NoUpdate_Photo(id, productVM, editProduct);
                    var translateWord = await _productRepository.TranslateWordAsync(product.Name_For_User);
                    string[] uaWords = new string[] { product.Name_For_User, product.Description, product.Sub_category, _productRepository.GetNameCategory(product.Category_id) };
                    string[] enWord = new string[] {
                        await _productRepository.TranslateWordAsync(uaWords[0]),
                        await _productRepository.TranslateWordAsync(uaWords[1]),
                        await _productRepository.TranslateWordAsync(uaWords[2]),
                        await _productRepository.TranslateWordAsync(uaWords[3])
                    };
                    string[] paths = new string[] {
                        "Resources\\Views\\Offers\\Offers.en.resx",
                        "Resources\\Views\\Offers\\OffersUseFilters.en.resx",
                        "Resources\\Views\\Offers\\Search.en.resx",
                        "Resources\\Views\\Orders\\Index.en.resx",
                        "Resources\\Views\\Product\\Index.en.resx"
                    };
                    await _productRepository.WriteToResources(uaWords, enWord, paths);
                    _productRepository.Update(product);
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
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Search(string serchTerm)
        {

            var response = await _httpClient.GetAsync("https://localhost:7091/api/Product/" + serchTerm);

            if (response.IsSuccessStatusCode)
            {
                var data = await response.Content.ReadAsAsync<List<Product>>();
                if (data.Count == 0)
                    return RedirectToAction("NotFound");
                return View(data);
            }
            return View();
        }
        public IActionResult NotFound()
        {
            return View();
        }
    }
}
