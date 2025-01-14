using Backend.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.IdentityModel.Tokens;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;
namespace Backend.Functions;

public static class Generator{

    public static SecurityToken GenerateJwtToken(User user,Employee employee, IConfiguration _configuration){

        var tokenHandler = new JwtSecurityTokenHandler();
        var key = Encoding.UTF8.GetBytes(_configuration["Jwt:Key"]);
        var tokenDescriptor = new SecurityTokenDescriptor {
            Subject = new ClaimsIdentity(new Claim[] {
                new Claim(ClaimTypes.Name, employee.FirstName),
                new Claim(ClaimTypes.Surname,employee.LastName),
                new Claim(ClaimTypes.Email,user.Email),
                new Claim(ClaimTypes.PrimarySid,user.EmployeeID.ToString()),
            }),
            Expires = DateTime.UtcNow.AddMinutes(10),
            SigningCredentials = new SigningCredentials(new SymmetricSecurityKey(key), SecurityAlgorithms.HmacSha256Signature)
        };

        return tokenHandler.CreateToken(tokenDescriptor);
    }

}