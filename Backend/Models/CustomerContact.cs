namespace Backend.Models;
public class CustomerContact
{
    public int ContactID { get; set; }
    public int CustomerID { get; set; }
    public ContactType ContactType { get; set; }
    public string ContactInfo { get; set; }
}
