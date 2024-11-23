namespace Backend.Models;
public class EmployeeContact
{
    public int ContactID { get; set; }
    public int EmployeeID { get; set; }
    public ContactType ContactType { get; set; }
    public string ContactInfo { get; set; }

}

public enum ContactType
{
    Phone=1,
    Email
}
