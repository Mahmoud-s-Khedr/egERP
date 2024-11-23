namespace Backend.Models;
public class EmployeeAttendance
{
    public int AttendanceID { get; set; }
    public int EmployeeID { get; set; }
    public DateTime AttendanceDate { get; set; }
    public TimeSpan? CheckInTime { get; set; }
    public TimeSpan? CheckOutTime { get; set; }
    public AttendanceStatus EmployeeAttendanceStatus { get; set; }
}

public enum AttendanceStatus
{
    Present=1,
    Absent,
    Late
}
