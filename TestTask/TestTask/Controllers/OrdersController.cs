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
    public class OrdersController : ControllerBase
    {
        private readonly Context context;
        private readonly IOrderService service;

        public OrdersController(Context _context, IOrderService _service)
        {
            context = _context;
            service = _service;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<Order>>> GetOrders()
        {
            return service.GetAllOrders();
        }


 
        [HttpPost]
        public async Task<ActionResult<Order>> PostOrder(Order order)
        {
            service.PostOrder(order);
            return CreatedAtAction("GetOrder", new { id = order.Id }, order);
        }


        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteOrder(int id)
        {
            var order = await context.Orders.FindAsync(id);
            if (order == null)
                return NotFound();
            service.DeleteOrder(order);
            return Ok();
        }
    }
}
