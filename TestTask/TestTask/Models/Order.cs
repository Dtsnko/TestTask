namespace TestTask.Models
{
    public class Order
    {
        public int Id { get; set; }
        public string Number { get; set; }
        public decimal Amount { get; set; }
        public List<OrderProduct> OrderProducts { get; set; }
    }
}
