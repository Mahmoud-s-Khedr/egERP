namespace Backend.Models;
public class EmployeeDepartmentTransfer
{
    public int TransferID { get; set; }
    public int EmployeeID { get; set; }
    public DateTime TransferDate { get; set; }
    public int NewDepartmentID { get; set; }
    public string? Reason { get; set; }
    public string? TransferStatus { get; set; }
    public int? OldDepartmentID { get; set; }

}