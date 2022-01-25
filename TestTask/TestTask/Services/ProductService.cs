using TestTask.Interfaces;
using TestTask.Models;

namespace TestTask.Services
{
    public class ProductService : IProductService
    {
        private readonly Context context;

        public ProductService(Context _context)
        {
            context = _context;
        }
        public void DeleteProduct(Product entity)
        {
            context.Products.Remove(entity);
            context.SaveChanges();
        }

        public List<Product> GetAllProducts()
        {
            return context.Products.ToList();
        }

        public void PostProduct(Product Product)
        {
            context.Products.Add(Product);
            context.SaveChanges();
        }
    }
}
