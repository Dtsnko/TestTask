using TestTask.Interfaces;
using TestTask.Models;

namespace TestTask.Services
{
    public class OrderProductService : IOrderProductService
    {
        readonly Context db;
        public OrderProductService(Context _db)
        {
            db = _db;
        }
        public void DeleteOrderProduct(OrderProduct entity)
        {
            db.OrderProducts.Remove(entity);
            db.SaveChanges();
        }

        public List<OrderProduct> GetAllOrderProducts()
        {
            return db.OrderProducts.ToList();
        }

        public void PostOrderProduct(OrderProduct orderProduct)
        {
            db.OrderProducts.Add(orderProduct);
            db.SaveChangesAsync();
        }
    }
}
