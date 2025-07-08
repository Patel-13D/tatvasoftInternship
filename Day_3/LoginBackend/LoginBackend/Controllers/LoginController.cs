using Microsoft.AspNetCore.Mvc;
using LoginApi.Models;

namespace LoginApi.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class LoginController : ControllerBase
    {
        // Hardcoded user for demo purpose
        private readonly string _validUsername = "admin";
        private readonly string _validPassword = "password123";

        [HttpPost]
        public IActionResult Login([FromBody] LoginModel login)
        {
            if (login == null || string.IsNullOrEmpty(login.Username) || string.IsNullOrEmpty(login.Password))
            {
                return BadRequest(new { message = "Username and password are required." });
            }

            if (login.Username == _validUsername && login.Password == _validPassword)
            {
                return Ok(new { message = "Login Successful" });
            }
            else
            {
                return Unauthorized(new { message = "Login Failed" });
            }
        }
    }
}
