using console_app;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace API.Controllers;


[ApiController]
[Route("[controller]")]
public class StudentController : Controller
{
    private readonly EducationContext _context;
    private readonly ILogger<StudentController> _logger;

    public StudentController(EducationContext context, ILogger<StudentController> logger )
    {
        _context = context;
        _logger = logger;
    }
    
    
    [HttpGet]
    public IActionResult Index()
    {
        try
        {
            return Ok(_context.Students.ToList()[2]);
        }
        catch (Exception ex)
        {
            _logger.LogCritical(ex, "List doesn't contain a third post");
        }
        
        return Ok(_context
            .Students
            .Include(s => s.Person)
            .Include(s => s.Courses)
            .ThenInclude(c => c.Institution)
            .ToList());
    }
    
    [Authorize]
    [HttpPost]
    public bool Index(Student student)
    {
        _context.Add(student);
        _context.SaveChanges();
        return true;
    }
}