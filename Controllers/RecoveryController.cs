using Appoiment_API.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using MimeKit;
using MailKit.Net.Smtp;

namespace Appoiment_API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RecoveryController : Controller
    {
        private readonly IConfiguration _config;
        private readonly APIDbContext _context;

        public RecoveryController(
            APIDbContext context,
            IConfiguration config)
        {
            _context = context;
            _config = config;
        }

        [HttpGet("{email}")]
        public async Task<IActionResult> RecoveryPassword(string email)
        {
            if (email != null)
            {
                var currentUser = await _context.Users.FirstOrDefaultAsync(
                    user => user.Email.ToLower() == email.ToLower());
                if (currentUser != null)
                {
                    sendRecoveryEmail(currentUser.Email, currentUser.Password);
                    return Ok(currentUser);
                }
            }
            return NotFound("User no encontrado");

        }

        private void sendRecoveryEmail(string emailReceiver, string password)
        {
            EncryptMD5 md5 = new EncryptMD5(_config);
            var email = new MimeMessage();

            email.From.Add(new MailboxAddress("Sender Name", "userdenssed@gmail.com"));
            email.To.Add(new MailboxAddress("Receiver Name", emailReceiver));

            email.Subject = "Testing out email sending";
            email.Body = new TextPart(MimeKit.Text.TextFormat.Html)
            {
                Text = "<b>Hola! Buenos dias, Usted solicito recuperacion de contraseña: </b>" + md5.Decryp(password)
            };

            using (var smtp = new SmtpClient())
            {
                smtp.Connect("smtp.gmail.com", 587, false);

                // Note: only needed if the SMTP server requires authentication
                smtp.Authenticate("userdenssed@gmail.com", "ilhucxateodeoqvg");

                smtp.Send(email);
                smtp.Disconnect(true);
            }
        }
    }
}
