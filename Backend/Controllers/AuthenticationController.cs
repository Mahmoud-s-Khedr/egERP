using  Backend.Data;
using Microsoft.AspNetCore.Mvc;
using Backend.Functions;
namespace Backend.Controllers;

[Route("auth/[controller]")]
[ApiController]
public class AuthenticationController : ControllerBase{

    public readonly ApplicationDbContext _context;
    public readonly IConfiguration _configuration;
    public AuthenticationController(ApplicationDbContext context, IConfiguration Configuration){
        _context = context;
        _configuration = Configuration;
    }

    [HttpPost("login")]
    public async Task<ActionResult<string>> Login(string email, string password) { 

        if (!Checker.loginCheck(email, password)) {
            return BadRequest("Email or password is invalid1");
        }

        var User = _context.Users.Where(u => u.Email == email && u.PasswordHash == password).First();
        if (!Checker.UserCheck(User)) {
            return BadRequest("Email or password is invalid2");
        }

        var Employee = _context.Employees.Where(e => e.EmployeeID == User.EmployeeID).First();
        var token = Generator.GenerateJwtToken(User,Employee, _configuration);

        return Ok(token);
    }

    

}