namespace Backend.Models;
public class SupplierAddress
{
    public int AddressID { get; set; }
    public int SupplierID { get; set; }
    public string AddressLine1 { get; set; }
    public string AddressLine2 { get; set; }
    public string City { get; set; }
    public string Province { get; set; }
    public string PostalCode { get; set; }
    public string Country { get; set; }

}
