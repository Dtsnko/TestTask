using TestTask.Models;

namespace TestTask.Interfaces
{
    public interface IOrderProductService
    {
        void GetAllOrderProducts();
        void PostOrderProduct(OrderProduct orderProduct);
        void DeleteOrderProduct(OrderProduct entity);
    }
}
