using Microsoft.AspNetCore.Mvc;

namespace API.Controllers;

public class TestController : Controller
{
    // GET
    public IActionResult Index()
    {
        return Ok("Test worked");
    }
}