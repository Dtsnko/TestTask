using TestTask.Interfaces;
using TestTask.Models;

namespace TestTask.Services
{
    public class OrderService : IOrderService
    {
        readonly Context db;
        public OrderService(Context _db)
        {
            db = _db;
        }
        public void DeleteOrder(Order entity)
        {
            db.Orders.Remove(entity);
            db.SaveChanges();
        }

        public List<Order> GetAllOrders()
        {
            return db.Orders.ToList();
        }

        public void PostOrder(Order orderProduct)
        {
            db.Orders.Add(orderProduct);
            db.SaveChanges();
        }
    }
}
