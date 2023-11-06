using Microsoft.AspNetCore.Mvc;
using PizzaExpress.Repositories.Interfaces;
using PizzaExpress.ViewModels;

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
            ViewData["Title"] = "Lista de Lanches";
            ViewData["Date"] = DateTime.Now;

            var productListViewModel = new ProductListViewModel();
            productListViewModel.Products = _productRepository.Products;
            productListViewModel.CurrentCategory = "Categoria Atual";

            return View(productListViewModel);
        }
    }
}
