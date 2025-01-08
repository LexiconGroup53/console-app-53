using console_app;
using Microsoft.EntityFrameworkCore;

namespace API;

public class EducationContext : DbContext
{
    public EducationContext(DbContextOptions<EducationContext> options) : base(options)
    {
    }
    public DbSet<Student> Students { get; set; }
}