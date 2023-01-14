using Microsoft.AspNetCore.Mvc;
using shokhov_shop.Intefaces;

namespace shokhov_shop.Controllers
{
    public class ProductController : Controller
    {
        private readonly IProductRepository productRepository;
        public ProductController(IProductRepository productRepository)
        {
            this.productRepository = productRepository;
        }

        public async Task<IActionResult> Index(int id)
        {
            var product = await productRepository.GetProduct(id);
            return View(product);
        }
    }
}
