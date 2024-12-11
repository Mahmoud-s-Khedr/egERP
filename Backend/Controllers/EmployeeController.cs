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
    public ActionResult<List<Employee>> getAllEmployees(int page, int pageSize){
        var list = _context.Employees?.OrderBy(x => x.EmployeeID).Skip((page - 1) * pageSize).Take(pageSize).ToList();

        if(list == null)
            return NotFound("there are no employees");

        return list;
    }
    [HttpGet("getEmployeeByID")]
    public ActionResult<Employee> getEmployeeByID(int id){
        var Employee = _context.Employees?.Where(x => x.EmployeeID == id).First();

        if(Employee == null)
            return NotFound("this employee does not exist");

        return Employee;
    }
    [HttpDelete("deleteEmployeeByID")]
    public ActionResult<Employee> deleteEmployeeByID(int id){
        var employee = _context.Employees?.Where(x => x.EmployeeID == id).First();

        if(employee == null)
            return NotFound("this employee does not exist to delete");

        _context.Employees?.Remove(employee);
        _context.SaveChanges();
        return employee;
    }
    [HttpPut("updateEmployeeByID")]
    public ActionResult<Employee> updateEmployeeByID(Employee employee){
        if(employee == null)
            return BadRequest("there is no employee to update");

        var test  = _context.Employees?.Where(x => x.EmployeeID == employee.EmployeeID).First();

        if(test == null)
            return NotFound("this employee does not exist to update");

        _context.Employees?.Update(employee);
        _context.SaveChanges();
        return employee;
    }
    [HttpPost("addEmployeeByID")]
    public ActionResult<Employee> addEmployeeByID(Employee employee){
        if(employee == null)
            return BadRequest("there is no employee to add");

        var test  = _context.Employees?.Where(x => x.EmployeeID == employee.EmployeeID).First();

        if(test != null)
            return BadRequest("this employee already exists");

        _context.Employees?.Add(employee);
         _context.SaveChangesAsync();
        return employee;
    }
    [HttpGet("getEmployeeByName")]
    public ActionResult<List<Employee>> getEmployeeByName(string name){
        if(name == null || name == "")
            return BadRequest("there is no name to search");

        var Employee = _context.Employees?.Where(x => x.FirstName == name).ToList();

        if(Employee == null)
            return NotFound("this employee does not exist");

        return Employee;
    }

    [HttpGet("getEmployeeByDepartmentID")]
    public ActionResult<List<Employee>> getEmployeeByDepartmentID(int id){
        var department = _context.Departments?.Where(x => x.DepartmentID == id).First();

        if(department == null)
            return NotFound("this department does not exist");

        var Employees = _context.Employees?.Where(x => x.DepartmentID == id).ToList();

        if(Employees == null)
            return NotFound("this department does have any employees");

        return Employees;
    }

    [HttpGet("getEmployeeAddressByID")]
    public ActionResult<List<EmployeeAddress>> getEmployeeAddressByID(int id){
        var addresses = _context.EmployeeAddresses?.Where(x => x.EmployeeID == id).ToList();

        if(addresses == null)
            return NotFound("this employee does not have any address");

        return addresses;
    }

    [HttpGet("getEmployeeContactByID")]
    public ActionResult<List<EmployeeContact>> getEmployeeContactByID(int id){
        var contacts = _context.EmployeeContacts?.Where(x => x.EmployeeID == id).ToList();

        if(contacts == null)
            return NotFound("this employee does not have any contact");

        return contacts;
    }

    [HttpGet("getEmployeeSkillsByID")]
    public ActionResult<List<EmployeeSkill>> getEmployeeSkillsByID(int id){
        var skills = _context.EmployeeSkills?.Where(x => x.EmployeeID == id).ToList();

        if(skills == null)
            return NotFound("this employee does not have any skills");

        return skills;
    }
    
    [HttpGet("getEmployeeLeavesByID")]
    public ActionResult<List<EmployeeLeave>> getEmployeeLeavesByID(int id){
        var leaves = _context.EmployeeLeaves?.Where(x => x.EmployeeID == id).ToList();
        if(leaves == null)
            return NotFound("this employee does not have any leaves");
        return leaves;
    }
    [HttpGet("getEmployeeAttendanceByID")]
    public ActionResult<List<EmployeeAttendance>> getEmployeeAttendanceByID(int id){
        var attendances = _context.EmployeeAttendances?.Where(x => x.EmployeeID == id).ToList();

        if(attendances == null)
            return NotFound("this employee does not have any attendances");

        return attendances;
    }

    [HttpPost("addEmployeeAddress")]
    public ActionResult<EmployeeAddress> addEmployeeAddress(EmployeeAddress employeeAddress){
        if(employeeAddress == null)
            return BadRequest("there is no address to add");

        var test  = _context.EmployeeAddresses?.Where(x => x.AddressID == employeeAddress.AddressID).First();

        if(test != null)
            return BadRequest("this address already exists");

        _context.EmployeeAddresses?.Add(employeeAddress);
        _context.SaveChanges();
        return employeeAddress;
    }
    [HttpPost("addEmployeeContact")]
    public ActionResult<EmployeeContact> addEmployeeContact(EmployeeContact employeeContact){
        if(employeeContact == null)
            return BadRequest("there is no contact to add");

        var test  = _context.EmployeeContacts?.Where(x => x.ContactID == employeeContact.ContactID).First();

        if(test != null)
            return BadRequest("this contact already exists");

        _context.EmployeeContacts?.Add(employeeContact);
         _context.SaveChanges();
        return employeeContact;
    }
    [HttpPost("addEmployeeSkill")]
    public ActionResult<EmployeeSkill> addEmployeeSkill(EmployeeSkill employeeSkill){
        if(employeeSkill == null)
            return BadRequest("there is no skill to add");

        var test = _context.EmployeeSkills?.Where(x => x.SkillID == employeeSkill.SkillID).First();

        if(test != null)
            return BadRequest("this skill already exists");

        _context.EmployeeSkills?.Add(employeeSkill);
        _context.SaveChanges();
        return employeeSkill;
    }
    [HttpPost("addEmployeeLeave")]
    public ActionResult<EmployeeLeave> addEmployeeLeave(EmployeeLeave employeeLeave){
        if(employeeLeave == null)
            return BadRequest("there is no leave to add");

        var test = _context.EmployeeLeaves?.Where(x => x.LeaveID == employeeLeave.LeaveID).First();

        if(test != null)
            return BadRequest("this leave already exists");

        _context.EmployeeLeaves?.Add(employeeLeave);
        _context.SaveChanges();
        return employeeLeave;
    }
    [HttpPost("addEmployeeAttendance")]
    public ActionResult<EmployeeAttendance> addEmployeeAttendance(EmployeeAttendance employeeAttendance){
        if(employeeAttendance == null)
            return BadRequest("there is no attendance to add");

        var test = _context.EmployeeAttendances?.Where(x => x.AttendanceID == employeeAttendance.AttendanceID).First();

        if(test != null)
            return BadRequest("this attendance already exists");

        _context.EmployeeAttendances?.Add(employeeAttendance);
        _context.SaveChanges();
        return employeeAttendance;
    }
    [HttpDelete("deleteEmployeeAddress")]
    public ActionResult deleteEmployeeAddress(EmployeeAddress employeeAddress){
        if(employeeAddress == null)
            return BadRequest("there is no address to delete");

        var test = _context.EmployeeAddresses?.Where(x => x.AddressID == employeeAddress.AddressID).First();

        if(test == null)
            return NotFound("this address does not exist to delete");

        _context.EmployeeAddresses?.Remove(employeeAddress);
        _context.SaveChanges();
        return Ok("deleted");
    }
    [HttpDelete("deleteEmployeeContact")]
    public ActionResult deleteEmployeeContact(EmployeeContact employeeContact){
        if(employeeContact == null)
            return BadRequest("there is no contact to delete");

        var test = _context.EmployeeContacts?.Where(x => x.ContactID == employeeContact.ContactID).First();

        if(test == null)
            return NotFound("this contact does not exist to delete");

        _context.EmployeeContacts?.Remove(employeeContact);
         _context.SaveChanges();
         return Ok("deleted");
    }
    [HttpDelete("deleteEmployeeSkill")]
    public ActionResult deleteEmployeeSkill(EmployeeSkill employeeSkill)
    {
        if(employeeSkill == null)
            return BadRequest("there is no skill to delete");

        var test = _context.EmployeeSkills?.Where(x => x.SkillID == employeeSkill.SkillID).First();

        if(test == null)
            return NotFound("this skill does not exist to delete");

        _context.EmployeeSkills?.Remove(employeeSkill);
        _context.SaveChanges();
        return Ok("deleted");
    }
    [HttpGet("getEmployeeBenefits")]
    public ActionResult<List<EmployeeBenefit>> getEmployeeBenefits(int id){
        var test = _context.Employees?.Where(x => x.EmployeeID == id).First();

        if(test == null)
            return NotFound("this employee does not exist");

        var benefits = _context.EmployeeBenefits?.Where(x => x.EmployeeID == id).ToList();

        if(benefits == null)
            return NotFound("this employee does not have any benefits");

        return benefits;
    }
    [HttpGet("allEmployeeBenefits")]
    public ActionResult<List<EmployeeBenefit>> allEmployeeBenefits(){
        var test = _context.EmployeeBenefits?.ToList();

        if(test == null)
            return NotFound("there are no benefits");

        return test;
    }

    [HttpPost("addEmployeeBenefit")]
    public ActionResult<EmployeeBenefit> addEmployeeBenefit(EmployeeBenefit employeeBenefit){
        if(employeeBenefit == null)
            return BadRequest("there is no benefit to add");

        var test = _context.EmployeeBenefits?.Where(x => x.BenefitID == employeeBenefit.BenefitID).First();

        if(test != null)
            return BadRequest("this benefit already exists");

        _context.EmployeeBenefits?.Add(employeeBenefit);
        _context.SaveChanges();
        return employeeBenefit;
    }

    [HttpGet("getEmployeeTrainings")]
    public ActionResult<List<EmployeeTraining>> getEmployeeTrainings(int id){
        var test = _context.Employees?.Where(x => x.EmployeeID == id).First();

        if(test == null)
            return NotFound("this employee does not exist");

        var trainings = _context.EmployeeTrainings?.Where(x => x.EmployeeID == id).ToList();

        if(trainings == null)
            return NotFound("this employee does not have any trainings");

        return trainings;
    }

    [HttpPost("addEmployeeTraining")]
    public ActionResult<EmployeeTraining> addEmployeeTraining(EmployeeTraining employeeTraining){
        if(employeeTraining == null)
            return BadRequest("there is no training to add");

        var test = _context.EmployeeTrainings?.Where(x => x.EmployeeTrainingID == employeeTraining.EmployeeTrainingID).First();
        
        if(test == null)
            return BadRequest("this training already exists");

        _context.EmployeeTrainings?.Add(employeeTraining);
        _context.SaveChanges();
        return employeeTraining;
    }
    [HttpGet("getEmployeeContracts")]
    public ActionResult<EmployeeContract> getEmployeeContract(int id){
        var test = _context.Employees?.Where(x => x.EmployeeID == id).First();

        if(test == null)
            return NotFound("this employee does not exist");

        var contract =  _context.EmployeeContracts?.Where(x => x.EmployeeID == id).First();

        if (contract == null)
            return NotFound("this employee does not have any contracts fix this ");

        return contract;
    }
    [HttpPost("addEmployeeContract")]
    public ActionResult<EmployeeContract> addEmployeeContract(EmployeeContract employeeContract){
        if(employeeContract == null)
            return BadRequest("there is no contract to add");

        var test = _context.EmployeeContracts?.Where(x => x.ContractID == employeeContract.ContractID).First();

        if(test != null)
            return BadRequest("this contract already exists");

        _context.EmployeeContracts?.Add(employeeContract);
        _context.SaveChanges();
        return employeeContract;
    }
    [HttpGet("getEmployeeResignations")]
    public ActionResult<EmployeeResignation> getEmployeeResignations(int id)
    {
        var test = _context.Employees?.Where(x => x.EmployeeID == id).First();

        if(test == null)
            return NotFound("this employee does not exist");

        var resignations = _context.EmployeeResignations?.Where(x => x.EmployeeID == id).First();

        if(resignations == null)
            return NotFound("this employee does not have any resignations");

        return resignations;
    }
    [HttpPost("addEmployeeResignation")]
    public ActionResult<EmployeeResignation> addEmployeeResignation(EmployeeResignation employeeResignation){
        if(employeeResignation == null)
            return BadRequest("there is no resignation to add");

        var test = _context.EmployeeResignations?.Where(x => x.ResignationID == employeeResignation.ResignationID).First();

        if(test != null)
            return BadRequest("this resignation already exists");
        
        _context.EmployeeResignations?.Add(employeeResignation);
        _context.SaveChangesAsync();
        return employeeResignation;
    }

    [HttpGet("getAllEmployeesPerformance")]
    public ActionResult<List<EmployeePerformance>> getllEmployeePerformance(int page, int pageSize,DateOnly reviewDate){
        if(page <= 0||pageSize <= 0)
            return BadRequest("invalid page or pageSize");
        
        var list =  _context.EmployeePerformances?.Where(x => x.ReviewDate >= reviewDate).Skip((page - 1) * pageSize).Take(pageSize).ToList();

        if(list == null)
            return NotFound("this page does not exist");

        return list;
    }
    [HttpGet("getEmployeePerformanceByID")]
    public ActionResult<List<EmployeePerformance>> getEmployeePerformanceByID(int id){
        var list =  _context.EmployeePerformances?.Where(x => x.EmployeeID == id).ToList();

        if(list == null)
            return NotFound("this employee does not exist");

        return list;
    }

    [HttpPost("addEmployeePerformance")]
    public ActionResult<EmployeePerformance> addEmployeePerformance(EmployeePerformance employeePerformance){
        if(employeePerformance == null)
            return BadRequest("there is no performance to add");
        
        var test = _context.EmployeePerformances?.Where(x => x.PerformanceID == employeePerformance.PerformanceID).First();

        if(test != null)
            return BadRequest("this performance already exists");
        
        _context.EmployeePerformances?.Add(employeePerformance);
        _context.SaveChanges();
        return employeePerformance;
    }

    [HttpPost("EmployeeDepartmentTransfersRequest")]
    public ActionResult<EmployeeDepartmentTransfer> EmployeeDepartmentTransfersRequest(EmployeeDepartmentTransfer employeeDepartmentTransferRequest){
        if(employeeDepartmentTransferRequest == null)
            return BadRequest("there is no transfer to add");
        
        var test = _context.EmployeeDepartmentTransfers?.Where(x => x.TransferID == employeeDepartmentTransferRequest.TransferID).First();

        if(test != null)
            return BadRequest("this transfer already exists");

        _context.EmployeeDepartmentTransfers?.Add(employeeDepartmentTransferRequest);
        _context.SaveChanges();
        return employeeDepartmentTransferRequest;
    }
    [HttpGet("getEmployeeDepartmentTransfers")]
    public ActionResult<List<EmployeeDepartmentTransfer>> getEmployeeDepartmentTransfers(){
        var list =  _context.EmployeeDepartmentTransfers?.ToList();

        if(list == null)
            return NotFound("there are no transfers");

        return list;
    }
    [HttpGet("getEmployeeDepartmentPendingTransfer")]
    public ActionResult<List<EmployeeDepartmentTransfer>> getEmployeeDepartmentPendingTransfer(){
        var list =   _context.EmployeeDepartmentTransfers?.Where(x => x.TransferStatus == "Pending").ToList();

        if(list == null)
            return NotFound("there are no pending transfers");

        return list;
    }
    [HttpPost("addEmployeeDepartmentTransferApproval")]//this should be handled by in the frontend
    public ActionResult addEmployeeDepartmentTransferApproval(EmployeeDepartmentTransfer employeeDepartmentTransferApproval){
        if(employeeDepartmentTransferApproval == null)
            return BadRequest("there is no transfer to add");
        
        _context.EmployeeDepartmentTransfers?.Update(employeeDepartmentTransferApproval);
        _context.SaveChanges();
        return Ok("approved");
    }

    [HttpPost("addEmployeeDepartmentTransferDecline")]
    public ActionResult addEmployeeDepartmentTransferDecline(EmployeeDepartmentTransfer employeeDepartmentTransferDecline){
        if(employeeDepartmentTransferDecline == null)
            return BadRequest("there is no transfer to add");

        _context.EmployeeDepartmentTransfers?.Update(employeeDepartmentTransferDecline);
        _context.SaveChangesAsync();
        return Ok("declined");
    }


}