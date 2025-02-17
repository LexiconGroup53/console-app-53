using console_app;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace API;

public class EducationContext : IdentityDbContext<IdentityUser>
{
    public EducationContext(DbContextOptions<EducationContext> options) : base(options)
    {
    }
    public DbSet<Student> Students { get; set; }
    public DbSet<Course> Courses { get; set; }
    public DbSet<Institution> Institutions { get; set; }
    public DbSet<Person> Persons { get; set; }
}