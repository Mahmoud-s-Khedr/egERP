namespace Backend.Models;
public class EmployeeLeave
{
    public int LeaveID { get; set; }
    public int EmployeeID { get; set; }
    public int LeaveTypeID { get; set; }
    public DateTime StartDate { get; set; }
    public DateTime EndDate { get; set; }
    public LeaveStatus EmployeeLeaveStatus { get; set; }
}

public enum LeaveStatus
{
    Pending=1,
    Approved,
    Rejected
}
