using PizzaExpress.Models;

namespace PizzaExpress.ViewModels
{
    public class ProductListViewModel
    {
        public IEnumerable<Product> Products { get; set; }
        public String CurrentCategory { get; set; }
    }
}
