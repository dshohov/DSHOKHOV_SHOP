using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Search_WebApi.Interface;
using Search_WebApi.Models;

namespace Search_WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        private readonly IProductRepository _productRepository;
        public ProductController(IProductRepository productRepository)
        {
            _productRepository = productRepository;
        }

        [HttpGet]
        [ProducesResponseType(200, Type = typeof(IEnumerable<Product>))]
        public IActionResult GetPoducts()
        {
            var products = _productRepository.GetProducts();

            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            return Ok(products);
        }
        [HttpGet("{searchTerm}")]
        [ProducesResponseType(200, Type = typeof(IEnumerable<Product>))]
        [ProducesResponseType(400)]
        public IActionResult GetProductBySearchTerm(string searchTerm)
        {
            var products = _productRepository.GetProductBySearchTerm(searchTerm);

            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            return Ok(products);
        }
    }
}
