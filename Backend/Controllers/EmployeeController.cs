using Backend.Data;
using Microsoft.AspNetCore.Mvc;
using Backend.Models;
namespace Backend.Controllers;

[Route("api/[controller]")]
[ApiController]
public class EmployeeController : ControllerBase
{
    private readonly ApplicationDbContext _context;
    public EmployeeController(ApplicationDbContext context)
    {
        _context = context;
    }
    [HttpGet("getAllEmployees")]
    public async Task<ActionResult<List<Employee>>> getAllEmployees(int page, int pageSize){
        return _context.Employees.OrderBy(x => x.EmployeeID).Skip((page - 1) * pageSize).Take(pageSize).ToList();
    }
    [HttpGet("getEmployeeByID")]
    public async Task<ActionResult<Employee>> getEmployeeByID(int id){
        var Employee = _context.Employees.Where(x => x.EmployeeID == id).First();
        return Employee;
    }
    [HttpDelete("deleteEmployeeByID")]
    public async Task<ActionResult<Employee>> deleteEmployeeByID(int id){
        var employee = _context.Employees.Where(x => x.EmployeeID == id).First();
        _context.Employees.Remove(employee);
        await _context.SaveChangesAsync();
        return employee;
    }
    [HttpPut("updateEmployee")]
    public async Task<ActionResult<Employee>> updateEmployee(Employee employee){
        _context.Employees.Update(employee);
        await _context.SaveChangesAsync();
        return employee;
    }
    [HttpPost("addEmployee")]
    public async Task<ActionResult<Employee>> addEmployee(Employee employee){
        _context.Employees.Add(employee);
        await _context.SaveChangesAsync();
        return employee;
    }
    [HttpGet("getEmployeeByName")]
    public async Task<ActionResult<List<Employee>>> getEmployeeByName(string name){
        var Employee = _context.Employees.Where(x => x.FirstName == name).ToList();
        return Employee;
    }

    [HttpGet("getEmployeeByDepartmentID")]
    public async Task<ActionResult<List<Employee>>> getEmployeeByDepartmentID(int id){
        var Employee = _context.Employees.Where(x => x.DepartmentID == id).ToList();
        return Employee;
    }
    

}