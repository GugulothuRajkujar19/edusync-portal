using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using MCA_Project_API.Data;
using MCA_Project_API.Models;

namespace MCA_Project_API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class FacultyController : ControllerBase
    {
        private readonly ApplicationDbContext _context;

        public FacultyController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: api/Faculty
        [HttpGet]
        public async Task<IActionResult> GetFaculty()
        {
            var faculty = await _context.Faculty.ToListAsync();
            return Ok(faculty);
        }
        [HttpPost("login")]
        public async Task<IActionResult> Login(Faculty login)
        {
            var faculty = await _context.Faculty
                .FirstOrDefaultAsync(f =>
                    f.Email == login.Email &&
                    f.Password == login.Password);

            if (faculty == null)
            {
                return Unauthorized("Invalid email or password");
            }

            return Ok(faculty);
        }
    }
}