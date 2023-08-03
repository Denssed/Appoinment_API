using Appoiment_API.Data;
using Appoiment_API.Data.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Query;
using Microsoft.OpenApi.Any;
using System.Collections.Immutable;

namespace Appoiment_API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AppoimentController : Controller
    {
        private readonly APIDbContext _context;
        private List<Ticket> tickets = new List<Ticket>();

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

        [HttpGet("{id}")]
        public async Task<ActionResult<Appoiment>> GetAppoiment(int  id)
        {
            var appoimnet =  await _context.Appoiments.FindAsync(id);
            if (appoimnet == null)
            {
                return NotFound();
            }

            return appoimnet;
        }

        //Get api/PatientController/:id
        [HttpGet("{id}")]
        public async Task<ActionResult<IEnumerable<Ticket>>> GetTicket(int id)
        {
            var appoiments = await _context.Appoiments.ToListAsync();
            var filter = appoiments.Where(p => p.Patient_id == id).ToArray();
            foreach (var appmt in appoiments)
            {
                if (appmt.Patient_id == id)
                {
                    var med = await _context.Users.FindAsync(appmt.Med_id);
                    var patient = await _context.Users.FindAsync(appmt.Patient_id);
                    var speciality = await _context.Specialities.FindAsync(appmt.Speciality_id);
                    Ticket memory = new Ticket { };
                    memory!.Med = med.Name;
                    memory!.Patient = patient.Name;
                    memory!.Speciality = speciality.Name;
                    memory!.Cost = appmt.Cost;
                    System.DateTime dat_Time = new System.DateTime(1965, 1, 1, 0, 0, 0, 0);
                    dat_Time = dat_Time.AddSeconds(appmt.Date_timeStamp);
                    string date = dat_Time.ToShortDateString() + " " + dat_Time.ToShortTimeString();
                    System.Console.WriteLine(date);
                    memory!.Date = date;
                    tickets.Add(memory);
                }
            }
                return tickets;
        }

        [HttpPost]
        public async Task<ActionResult<Appoiment>> PostProduct(Appoiment appoiment)
        {
            _context.Appoiments.Add(appoiment);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetAppoiment", new { id = appoiment.Id }, appoiment);
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
