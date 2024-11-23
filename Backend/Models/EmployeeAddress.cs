namespace Backend.Models;
public class EmployeeAddress
{
    public int AddressID { get; set; }
    public int EmployeeID { get; set; }
    public string AddressLine1 { get; set; }
    public string AddressLine2 { get; set; }
    public string City { get; set; }
    public string Province { get; set; }
    public string Country { get; set; }

}
