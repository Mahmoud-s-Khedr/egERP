namespace Backend.Models;
public class User
{
    public int UserID { get; set; }
    public string? PasswordHash { get; set; }
    public string? Email { get; set; }
    public bool IsActive { get; set; } = true; // Default value TRUE for IsActive
    public DateTime CreatedAt { get; set; } = DateTime.UtcNow; // Default value for CreatedAt
    public int? EmployeeID { get; set; } // Nullable because it can be NULL

}
