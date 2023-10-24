using PizzaExpress.Models;

namespace PizzaExpress.Repositories.Interfaces
{
    public interface ICategoryRepository
    {
        IEnumerable<Category> Categories { get; }
    }
}
