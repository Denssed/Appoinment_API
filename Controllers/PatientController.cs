using Appoiment_API.Data;
using Appoiment_API.Data.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Appoiment_API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PatientController : Controller
    {
        private readonly APIDbContext _context;

        public PatientController(APIDbContext context)
        {
            _context = context;
        }
        //Get api/PatientController
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Patient>>> GetUsers()
        {
            return await _context.Patients.ToListAsync();
        }

        //Get api/PatientController/:id
        [HttpGet("{id}")]
        public async Task<ActionResult<Patient>> GetAppoiment(int id)
        {
            var patient = await _context.Patients.FindAsync(id);

            if (patient == null)
            {
                return NotFound();
            }

            return patient;
        }
    }
}
