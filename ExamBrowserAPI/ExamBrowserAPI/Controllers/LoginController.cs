using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;
using ExamBrowserAPI.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.IdentityModel.Tokens;

namespace ExamBrowserAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class LoginController : ControllerBase
    {
        private readonly ExamBrowserDbContext _context;
        private readonly IConfiguration _config;

        public LoginController(ExamBrowserDbContext context, IConfiguration config)
        {
            _context = context;
            _config = config;
        }

        public class LoginRequest
        {
            public string Username { get; set; } = string.Empty;
            public string Password { get; set; } = string.Empty;
        }

        [HttpPost("login")]
        public async Task<IActionResult> Login([FromBody] LoginRequest request)
        {
            var admin = await _context.Admins
                .FirstOrDefaultAsync(a => a.Username == request.Username && a.Password == request.Password);
            if (admin != null)
                return Ok(new { Token = GenerateJwtToken(admin.Username, "Admin"), Role = "Admin", ExpiredAt = DateTime.UtcNow.AddMinutes(120) });

            var teacher = await _context.Teachers
                .FirstOrDefaultAsync(t => t.Username == request.Username && t.Password == request.Password);
            if (teacher != null)
                return Ok(new { Token = GenerateJwtToken(teacher.Username, "Teacher"), Role = "Teacher", ExpiredAt = DateTime.UtcNow.AddMinutes(120) });

            var student = await _context.Students
                .FirstOrDefaultAsync(s => s.Username == request.Username && s.Password == request.Password);
            if (student != null)
                return Ok(new { Token = GenerateJwtToken(student.Username, "Student"), Role = "Student", ExpiredAt = DateTime.UtcNow.AddMinutes(120) });

            return Unauthorized("Invalid username or password");
        }

        private string GenerateJwtToken(string username, string role)
        {
            var jwtSettings = _config.GetSection("Jwt");
            var key = Encoding.ASCII.GetBytes(jwtSettings["Key"]!);

            var tokenHandler = new JwtSecurityTokenHandler();
            var tokenDescriptor = new SecurityTokenDescriptor
            {
                Subject = new ClaimsIdentity(new[]
                {
                    new Claim(ClaimTypes.Name, username),
                    new Claim(ClaimTypes.Role, role)
                }),
                Expires = DateTime.UtcNow.AddMinutes(30), 
                Issuer = jwtSettings["Issuer"],
                Audience = jwtSettings["Audience"],
                SigningCredentials = new SigningCredentials(new SymmetricSecurityKey(key),SecurityAlgorithms.HmacSha256Signature)
            };

            var token = tokenHandler.CreateToken(tokenDescriptor);
            return tokenHandler.WriteToken(token);
        }
    }

    
}
