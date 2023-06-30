using Appoiment_API.Data;
using Appoiment_API.Data.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Appoiment_API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MedsController : Controller
    {
        private readonly APIDbContext _context;

        public MedsController(APIDbContext context)
        {
            _context = context;
        }

        //Get api/MedsController/
        [HttpGet]
        public async Task<ActionResult<IEnumerable<User>>> GetMeds()
        {
            return await _context.Users.ToListAsync();
        }
    }
}
