using Microsoft.EntityFrameworkCore;

namespace mvc_demo.Models
{
    public class StudentDBContext : DbContext
    {
        public StudentDBContext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<StudentModel> Students { get; set; }
    }
}
