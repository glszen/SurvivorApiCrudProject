using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using SurvivorProject.Data;
using SurvivorProject.Models;

namespace SurvivorProject.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CategoryController : ControllerBase
    {
        private readonly SurvivorContext _context;

        public CategoryController(SurvivorContext context)
        {
            _context = context;
        }

        [HttpGet("/api/categories")] //List all categories.
        public async Task<IActionResult> Get()
        {
            var list = await _context.Categories.ToListAsync();
            return Ok(list);
        }

        [HttpGet("/api/categories/{id}")] //List category by Id.
        public async Task<IActionResult> GetByCategory(int id)
        {
            var category = await _context.Categories.FirstOrDefaultAsync(c => c.Id == id);
            if (category is null) return NotFound();
            return Ok(category); 
        }

        [HttpPost("api/categories")] //Add a new category.
        public async Task<IActionResult> Create (Category category)
        {
            var createCategory = _context.Add(category);
            await _context.SaveChangesAsync();
            return CreatedAtAction(nameof(GetByCategory), new { id = category.Id } , category) ;
        }

        [HttpDelete("/api/categories/{id}")] //Delete category.
        public async Task<IActionResult> Delete (Category category)
        {
            var categoryDelete = await _context.Categories.FirstOrDefaultAsync(d => d.Id == category.Id);
            if (categoryDelete is null) return NotFound();
            _context.Categories.Remove(categoryDelete);
            return Ok(category);
        }
    }
}
