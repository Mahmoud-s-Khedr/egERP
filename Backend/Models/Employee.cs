namespace Backend.Models;
public class Employee
{
    public int EmployeeID { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public int? DepartmentID { get; set; } // Nullable because it can be NULL
    public string JobTitle { get; set; }
    public DateTime? HireDate { get; set; } // Nullable because it can be NULL
    public decimal? Salary { get; set; } // Nullable because it can be NULL
}
