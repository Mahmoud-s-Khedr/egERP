namespace Backend.Models;
public class AuditLog
{
    public int AuditID { get; set; }
    public string TableName { get; set; }
    public int RecordID { get; set; }
    public AuditAction AuditAction { get; set; }
    public int? UserID { get; set; } // Nullable because it can be NULL
    public DateTime ActionTime { get; set; } = DateTime.UtcNow; // Default value for ActionTime
    public string Reason { get; set; }

}

public enum AuditAction
{
    INSERT = 1,
    UPDATE,
    DELETE
}
