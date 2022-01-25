﻿namespace TestTask.Models
{
    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }
        public List<OrderProduct> OrderProducts { get; set; }
    }
}
