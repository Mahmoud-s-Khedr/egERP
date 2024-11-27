namespace Backend.Models;
public class EmployeeResignation
{
    public int ResignationID { get; set; }
    public int EmployeeID { get; set; }
    public DateTime ResignationDate { get; set; }
    public string? Reason { get; set; }
    public EmployeeResignationStatus ResignationStatus { get; set; }

}

public enum EmployeeResignationStatus
{
    Pending=1,
    Approved,
    Rejected
}
