namespace Backend.Models;
public class SupplierContact
{
    public int ContactID { get; set; }
    public int SupplierID { get; set; }
    public ContactType ContactType { get; set; }
    public string ContactInfo { get; set; }

}
