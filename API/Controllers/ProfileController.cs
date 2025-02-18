using System.Security.Claims;
using API.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers;

[ApiController]
[Route("myprofile")]
public class ProfileController : ControllerBase
{
    private readonly UserManager<AppUser> _userManager;

    public ProfileController(UserManager<AppUser> userManager, EducationContext context)
    {
        _userManager = userManager;
    }
    
    [HttpGet]
    public IActionResult Index()
    {
        var currentUserId = User.FindFirstValue(ClaimTypes.NameIdentifier);
        var userProfile = _userManager.Users.FirstOrDefault(p => p.Id == currentUserId);
        return Ok(userProfile);
    }
}