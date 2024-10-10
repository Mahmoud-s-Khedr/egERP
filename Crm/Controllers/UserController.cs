

using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.IdentityModel.Tokens;
namespace Crm.Controllers{
   
    [ApiController]
    [Route("api/[controller]")]
    public class UserController:ControllerBase{
        private readonly AppDbContext _context;
        private readonly JwtOptions _jwtOptions;
        public UserController(AppDbContext context,JwtOptions jwtOptions){
            _context = context;
            _jwtOptions = jwtOptions;
        }

        [HttpGet]
        [Route("getlogin")]

        public ActionResult<IEnumerable<LogInModel>> getlogin(){
            return Ok(_context.LogInModels.ToList());
        }

        
        [HttpPost]
        [Route("LogIn")]

        public ActionResult<string> LogIn(LogInModel user){
            var employee=_context.LogInModels.AsNoTracking().FirstOrDefault(e=>e.UserName==user.UserName && e.Password==user.Password);
            if(employee==null){
                return BadRequest("Invalid Username or Password");
            }
            var tokenHandler = new JwtSecurityTokenHandler();
            var tokenDescriptor = new SecurityTokenDescriptor{
                Issuer = _jwtOptions.Issuer,
                Audience = _jwtOptions.Audience,
                SigningCredentials = new SigningCredentials(new SymmetricSecurityKey(
                    Encoding.UTF8.GetBytes(_jwtOptions.SigningKey)),SecurityAlgorithms.HmacSha256),
                Subject = new ClaimsIdentity(new Claim[]{
                    new(ClaimTypes.NameIdentifier,employee.UserName),
                    new("id",employee.EmployeeId.ToString())
                })

            };
            var SecurityKey=tokenHandler.CreateToken(tokenDescriptor); 
            var AccessToken=tokenHandler.WriteToken(SecurityKey);

            return Ok(AccessToken);
        }
        [HttpGet]
        [Route("GetUsers")]


        public ActionResult<IEnumerable<Employee>> GetUsers(){
            return Ok(_context.Employees.ToList());
        }
    }
}