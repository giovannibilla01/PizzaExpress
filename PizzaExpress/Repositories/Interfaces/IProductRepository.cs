using PizzaExpress.Models;

namespace PizzaExpress.Repositories.Interfaces
{
    public interface IProductRepository
    {
        IEnumerable<Product> Products { get; }
        IEnumerable<Product> FavoriteProducts { get; }
        Product GetProductById(int id);
    }
}
