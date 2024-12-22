using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using SurvivorProject.Data;
using SurvivorProject.Models;

namespace SurvivorProject.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CompetitorController : ControllerBase
    {

        private readonly SurvivorContext _context;

        public CompetitorController(SurvivorContext context)
        {
            _context = context;
        }

       
        [HttpGet("api/competitors")] //List all competitor.
        public async Task<IActionResult> Get()
        {
            var list = await _context.Competitors.ToListAsync();
            return Ok(list);
        }

        [HttpGet("/api/competitors/{id}")] //List competitor by Id.
        public async Task<ActionResult> GetById(int id) //Action Result using for status commands.
        {
            var competitor = await _context.Competitors.FirstOrDefaultAsync(c => c.Id == id);
            if (competitor is null) return NotFound();
            return Ok(competitor);
        }

        [HttpGet("/api/competitors/categories/{CategoryId}")] //List competitor by CategoryId.
        public async Task<ActionResult> GetByCategoryId(int CategoryId)
        {
            var competitorCategory = await _context.Competitors.FirstOrDefaultAsync(i => i.CategoryId == CategoryId);
            if (competitorCategory is null) return NotFound();
            return Ok(competitorCategory);
        }

        [HttpPost("/api/competitors")] //Add new competitor.
        public async Task<ActionResult> Create (Competitor competitor)
        {
            _context.Competitors.Add(competitor);

            await _context.SaveChangesAsync();

            return CreatedAtAction(nameof(GetById), new { id = competitor.Id }, competitor);
        }

        [HttpPut("/api/competitors/{id}")] //Delete competitor.
        public async Task<ActionResult> Delete (Competitor competitor)
        {
            var competitorDelete = await _context.Competitors.FirstOrDefaultAsync(d => d.Id == competitor.Id);
            if (competitorDelete is null) return NotFound();
            _context.Competitors.Remove(competitorDelete);
            return Ok(competitorDelete);

        }

    }
}
