using Appoiment_API.Data;
using Appoiment_API.Data.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.IdentityModel.Tokens;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;

namespace Authenticator.Controllers
{
    [Route("/api/[controller]")]
    [ApiController]
    public class LoginController : Controller
    {
        private readonly IConfiguration _config;
        private readonly APIDbContext _context;

        public LoginController(
            APIDbContext context,
            IConfiguration config)
        {
            _context = context;
            _config = config;
        }

        [HttpPost]
        public IActionResult Login(LoginUser userLogin)
        {
            var user = Authenticate(userLogin);

            if(user != null)
            {
                //Crear token
                var token = Generate(user);

                return Ok(token);
            }

            return NotFound("User no encontrado");
        }

        private User Authenticate(LoginUser userLogin)
        {
            var currentUser = _context.Users.FirstOrDefault(
                user => user.Email.ToLower() == userLogin.Email.ToLower()
                && user.Password == userLogin.Password
                ) ;
            if (currentUser != null) {
                return currentUser;
            }
            return null;
        }

        private string Generate(User user)
        {
            var securityKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(_config["Jwt:Key"]));
            var credentials = new SigningCredentials(securityKey, SecurityAlgorithms.HmacSha256);

            //Crear los claims

            var claims = new[]
                    {
                        new Claim(ClaimTypes.NameIdentifier, user.Email),
                        new Claim(ClaimTypes.Role, user.Role),
                    };

            //Crear el token
            var token = new JwtSecurityToken(
                _config["Jwt:Issuer"],
                _config["Jwt:Audience"],
                claims,
                expires: DateTime.Now.AddMinutes(15),
                signingCredentials: credentials);

            return new JwtSecurityTokenHandler().WriteToken(token);
        }
    }
}
