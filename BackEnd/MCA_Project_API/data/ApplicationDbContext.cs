using Microsoft.EntityFrameworkCore;
using MCA_Project_API.Models;

namespace MCA_Project_API.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public DbSet<Student> Students { get; set; }

        public DbSet<Faculty> Faculty { get; set; }
    }
}
