using Appoiment_API.Data;
using Appoiment_API.Data.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Data;

namespace Appoiment_API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [Authorize(Roles = ("patient"))]
    public class PatientController : Controller
    {
        private readonly APIDbContext _context;

        public PatientController(APIDbContext context)
        {
            _context = context;
        }
        //Get api/PatientController
        [HttpGet]
        public async Task<ActionResult<IEnumerable<User>>> GetUsers()
        {
            return await _context.Users.ToListAsync();
        }

        //Get api/PatientController/:id
        [HttpGet("{id}")]
        public async Task<ActionResult<User>> GetAppoiment(int id)
        {
            var patient = await _context.Users.FindAsync(id);

            if (patient == null)
            {
                return NotFound();
            }

            return patient;
        }
    }
}
