#nullable disable
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using TestTask;
using TestTask.Interfaces;
using TestTask.Models;

namespace TestTask.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class OrderProductsController : ControllerBase
    {
        private readonly Context context;
        private readonly IOrderProductService service; 

        public OrderProductsController(Context _context, IOrderProductService _service)
        {
            context = _context;
            service = _service;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<OrderProduct>>> GetOrderProducts()
        {
            return service.GetAllOrderProducts();
        }


      
        [HttpPost]
        public async Task<ActionResult<OrderProduct>> PostOrderProduct(OrderProduct orderProduct)
        {
            service.PostOrderProduct(orderProduct);
            return CreatedAtAction("GetOrderProduct", new { id = orderProduct.Id }, orderProduct);
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteOrderProduct(int id)
        {
            var orderProduct = await context.OrderProducts.FindAsync(id);
            if (orderProduct == null)
            {
                return NotFound();
            }
            service.DeleteOrderProduct(orderProduct);
            return NoContent();
        }
    }
}
