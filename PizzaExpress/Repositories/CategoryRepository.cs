using PizzaExpress.Models;
using PizzaExpress.Models.Context;
using PizzaExpress.Repositories.Interfaces;

namespace PizzaExpress.Repositories
{
    public class CategoryRepository : ICategoryRepository
    {
        private readonly AppDbContext _context;

        public CategoryRepository(AppDbContext context)
        {
            _context = context;
        }

        public IEnumerable<Category> Categories => _context.Categories;
    }
}
