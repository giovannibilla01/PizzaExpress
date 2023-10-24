using Microsoft.AspNetCore.Mvc;
using PizzaExpress.Repositories.Interfaces;

namespace PizzaExpress.Controllers
{
    public class ProductController : Controller
    {
        private readonly IProductRepository _productRepository;

        public ProductController(IProductRepository productRepository)
        {
            _productRepository = productRepository;
        }

        public IActionResult List()
        {
            var product = _productRepository.Products;
            return View(product);
        }
    }
}
