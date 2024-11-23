namespace Backend.Models;
public class DepartmentManager
{
    public int ManagerID { get; set; }
    public int DepartmentID { get; set; }
    public bool IsActive { get; set; } = true; // Default value TRUE for IsActive
}
