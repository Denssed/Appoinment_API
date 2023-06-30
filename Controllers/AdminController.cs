using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Data;

namespace Appoiment_API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [Authorize(Roles = ("admin"))]
    public class AdminController : Controller
    {
        
    }
}
