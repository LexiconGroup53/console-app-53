using console_app;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers;

[ApiController]
[Route("[controller]")]
public class StudentController : Controller
{
    private readonly EducationContext _context;

    public StudentController(EducationContext context)
    {
        _context = context;
    }
    
    [HttpGet]
    public List<Student> Index()
    {
        return _context.Students.ToList();
    }

    [HttpPost]
    public bool Index(Student student)
    {
        _context.Add(student);
        _context.SaveChanges();
        return true;
    }
}