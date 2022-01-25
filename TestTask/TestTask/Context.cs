using Microsoft.EntityFrameworkCore;
using TestTask.Models;

namespace TestTask
{
    public class Context : DbContext
    {
        public DbSet<Order> Orders { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<OrderProduct> OrderProducts { get; set; }

        public Context(DbContextOptions<Context> options) : base(options)
        {
            Database.EnsureCreated();
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<OrderProduct>(entity =>
            {
                entity.HasOne(d => d.Order)
                .WithMany(d => d.OrderProducts)
                .HasForeignKey(d => d.OrderId);

                entity.HasOne(d => d.Product)
                .WithMany(d => d.OrderProducts)
                .HasForeignKey(d => d.ProductId);
            });

        }
    }
}
