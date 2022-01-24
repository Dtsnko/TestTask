using TestTask.Models;

namespace TestTask.Interfaces
{
    public interface IOrderService
    {
        List<Order> GetAllOrders();
        void PostOrder(Order orderProduct);
        void DeleteOrder(Order entity);
    }
}
