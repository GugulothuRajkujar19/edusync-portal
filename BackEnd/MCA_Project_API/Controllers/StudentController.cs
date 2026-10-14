using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using MCA_Project_API.Data;
using MCA_Project_API.Models;

namespace MCA_Project_API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class StudentController : ControllerBase
    {
        private readonly ApplicationDbContext _context;

        public StudentController(ApplicationDbContext context)
        {
            _context = context;
        }

        [HttpGet]
        public async Task<IActionResult> GetStudents()
        {
            var students = await _context.Students.ToListAsync();
            return Ok(students);
        }

        [HttpPost("login")]
        public async Task<IActionResult> Login(Student login)
        {
            var student = await _context.Students
                .FirstOrDefaultAsync(s =>
                    s.Email == login.Email &&
                    s.Password == login.Password);

            if (student == null)
            {
                return Unauthorized("Invalid email or password");
            }

            return Ok(student);
        }
    }
}
