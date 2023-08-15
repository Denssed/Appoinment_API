using Appoiment_API.Data;
using Appoiment_API.Data.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Appoiment_API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SpecialityController : Controller
    {
       
        private readonly APIDbContext _context;

        public SpecialityController(APIDbContext context)
        {
            _context = context;
        }
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Speciality>>> GetSpecialities()
        {
            return await _context.Specialities.ToListAsync();
        }
    }
}
