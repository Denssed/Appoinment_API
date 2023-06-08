using Appoiment_API.Data;
using Appoiment_API.Data.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Appoiment_API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AppoimentController : Controller
    {
        private readonly APIDbContext _context;

        public AppoimentController(APIDbContext context)
        {
            _context = context;
        }

        //Get api/AppoimentController/
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Appoiment>>> GetAppoiments()
        {
            return await _context.Appoiments.ToListAsync();
        }

        //Get api/AppoimentController/:id
        [HttpGet("{id}")]
        public async Task<ActionResult<Appoiment>> GetAppoiment(int id)
        {
            var appoiment = await _context.Appoiments.FindAsync(id);

            if (appoiment == null)
            {
                return NotFound();
            }

            return appoiment;
        }

        [HttpPost]
        public async Task<ActionResult<Appoiment>> PostProduct(Appoiment appoiment)
        {
            _context.Appoiments.Add(appoiment);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetProduct", new { id = appoiment.Id }, appoiment);
        }

        [HttpPut("{id}")]
        public async Task<ActionResult<Appoiment>> UpdateAppoiment(int id, Appoiment appoiment)
        {
            if (appoiment.Id != id)
            {
                return BadRequest("No Existe");
            }
            _context.Entry(appoiment).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (
            DbUpdateConcurrencyException)
            {
                if (!AppoimentExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return NoContent();
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteAppoiment(int id)
        {
            var product = await _context.Appoiments.FindAsync(id);
            if (product == null)
            {
                return NotFound();
            }

            _context.Appoiments.Remove(product);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool AppoimentExists(int id)
        {
            return _context.Appoiments.Any(p => p.Id == id);
        }
    }
}
