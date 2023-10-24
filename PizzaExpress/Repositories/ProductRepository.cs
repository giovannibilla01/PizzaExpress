using Microsoft.EntityFrameworkCore;
using PizzaExpress.Models;
using PizzaExpress.Models.Context;
using PizzaExpress.Repositories.Interfaces;

namespace PizzaExpress.Repositories
{
    public class ProductRepository : IProductRepository
    {
        private readonly AppDbContext _context;
        public ProductRepository(AppDbContext context)
        {
            _context = context;
        }

        IEnumerable<Product> IProductRepository.Products => _context.Products.Include(cat => cat.Category);

        IEnumerable<Product> IProductRepository.FavoriteProducts => _context.Products.
            Where(prod => prod.Favorite).
            Include(cat => cat.Category);

        Product IProductRepository.GetProductById(int id)
        {
            return _context.Products.FirstOrDefault(prod => prod.Id == id);
        }
    }
}
