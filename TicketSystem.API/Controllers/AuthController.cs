using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using TicketSystem.API.Models;

namespace TicketSystem.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AuthController : ControllerBase
    {
        private readonly TicketDbContext _Context;

        public AuthController(TicketDbContext context)
        {
            _Context = context;
        }
        [HttpPost("Login")]
        public IActionResult Login (LoginRequest Request)
        {
            var user = _Context.Users.FirstOrDefault(u=>u.Username == Request.UserName && u.Password==Request.Password);
            

            if (user == null) 
            return Unauthorized("Invalid Login");

            return Ok(new { user.UserId, user.Role });
        }
    }

    
}
