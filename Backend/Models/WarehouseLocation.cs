namespace Backend.Models;
public class WarehouseLocation
{
    public int LocationID { get; set; }
    public int WarehouseID { get; set; }
    public string LocationName { get; set; }
    public string AddressLine1 { get; set; }
    public string AddressLine2 { get; set; }
    public string City { get; set; }
    public string Province { get; set; }
    public string Country { get; set; }
    public string PostalCode { get; set; }

}
