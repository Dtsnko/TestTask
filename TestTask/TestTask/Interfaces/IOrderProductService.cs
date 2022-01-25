using TestTask.Models;

namespace TestTask.Interfaces
{
    public interface IOrderProductService
    {
        List<OrderProduct> GetAllOrderProducts();
        void PostOrderProduct(OrderProduct orderProduct);
        void DeleteOrderProduct(OrderProduct entity);
    }
}
