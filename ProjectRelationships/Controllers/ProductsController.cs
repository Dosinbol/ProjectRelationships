using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using ProjectRelationships.Data;

namespace ProjectRelationships.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductsController : ControllerBase
    {
        private readonly AppDbContext _context;
        public ProductsController(AppDbContext context)
        {
            _context = context;
        }

        [HttpGet]
        public async Task<ActionResult<List<Product>>> Get(int categoryId)
        {
            var products = await _context.Products.Where(c => c.CategoryId == categoryId).ToListAsync();
            if (products == null)
            {
                return NotFound();
            }
            return products;
        }

    }
}
