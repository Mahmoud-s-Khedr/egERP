namespace Backend.Models;
public class EmployeeContact
{
    public int ContactID { get; set; }
    public int EmployeeID { get; set; }
    public string? ContactType { get; set; }
    public string? ContactInfo { get; set; }

}