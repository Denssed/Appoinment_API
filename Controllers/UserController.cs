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
        //Get api/UserController
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Patient>>> GetUsers()
        {
            return await _context.Patients.ToListAsync();
        }
    }
}
