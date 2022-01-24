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
    public class ProductsController : ControllerBase
    {
        private readonly Context context;
        private readonly IProductService service;

        public ProductsController(Context _context, IProductService _service)
        {
            context = _context;
            service = _service;

        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<Product>>> GetProducts()
        {
            return service.GetAllProducts();
        }
   
        [HttpPost]
        public async Task<ActionResult<Product>> PostProduct(Product product)
        {
            service.PostProduct(product);
            return CreatedAtAction("GetProduct", new { id = product.Id }, product);
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteProduct(int id)
        {
            var product = await context.Products.FindAsync(id);
            if (product == null)
                return NotFound();
            service.DeleteProduct(product);
            return NoContent();
        }

 
    }
}
