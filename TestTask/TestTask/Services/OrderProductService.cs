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

        public void GetAllOrderProducts()
        {
            throw new NotImplementedException();
        }

        public void PostOrderProduct(OrderProduct orderProduct)
        {
            throw new NotImplementedException();
        }
    }
}
