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
            var users = await _context.Users.ToListAsync();
            var meds = users.Where(u => u.Role == "med").ToArray();
            //Console.WriteLine(meds);
            return meds;
        }

        //Get api/MedsController/:id
        //[HttpGet("{id}")]
        //public async Task<ActionResult<User>> GetMedById(int id)
        //{
        //    var med = await _context.Users.FindAsync(id);

        //    if (med == null)
        //    {
        //        return NotFound();
        //    }

        //    return med;
        //}

        //Get api/MedsController/:id
        [HttpGet("{id}")]
        public async Task<ActionResult<IEnumerable<User>>> GetMedBySpecialityId(int id)
        {
            var users = await _context.Users.ToListAsync();
            var meds = users.Where(u => u.Speciality_id == id).ToArray();
            if (meds == null)
            {
                return NotFound();
            }

            return meds;
        }

    }

}
