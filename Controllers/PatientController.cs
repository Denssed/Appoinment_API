using Appoiment_API.Data;
using Appoiment_API.Data.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Data;
using static Org.BouncyCastle.Math.EC.ECCurve;

namespace Appoiment_API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    //[Authorize(Roles = ("patient"))]
    public class PatientController : Controller
    {
        private readonly IConfiguration _config;
        private readonly APIDbContext _context;

        public PatientController(
            APIDbContext context,
            IConfiguration config)
        {
            _context = context;
            _config = config;
        }
        //Get api/PatientController
        [HttpGet]
        public async Task<ActionResult<IEnumerable<User>>> GetUsers()
        {
            EncryptMD5 md5 = new EncryptMD5(_config);
            var users = await _context.Users.ToListAsync();
            foreach (var user in users)
            {
                user.Password = md5.Decryp(user.Password);
            };

            return users;
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

        [HttpPut("{id}")]
        public async Task<ActionResult<User>> UpdatePatient(int id, User patient)
        {
            if (patient.Id != id)
            {
                return BadRequest("No Existe");
            }
            _context.Entry(patient).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!PatientExists(id))
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

        private bool PatientExists(int id)
        {
            return _context.Users.Any(p => p.Id == id);
        }
    }
}
