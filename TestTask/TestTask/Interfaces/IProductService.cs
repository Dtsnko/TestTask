using TestTask.Models;

namespace TestTask.Interfaces
{
    public interface IProductService
    {
        List<Product> GetAllProducts();
        void PostProduct(Product Product);
        void DeleteProduct(Product entity);
    }
}
