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
    public ActionResult<string> Login(string email, string password) { 

        if (!Checker.loginCheck(email, password)) {
            return BadRequest("Email or password is invalid");
        }

        var User = _context.Users?.Where(u => u.Email == email && u.PasswordHash == password).First();
        
        if(User == null){
            return BadRequest("Email or password is invalid");
        }

        if (!Checker.UserCheck(User)) {
            return BadRequest("Email or password is invalid");
        }

        var Employee = _context.Employees?.Where(e => e.EmployeeID == User.EmployeeID).First();

        if(Employee == null){
            return BadRequest("Email or password is invalid");
        }

        var token = Generator.GenerateJwtToken(User,Employee, _configuration);

        return Ok(token);
    }

    

}