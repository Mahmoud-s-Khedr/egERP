namespace Backend.Models;
public class Batch
{
    public int BatchID { get; set; }
    public int ProductID { get; set; }
    public string BatchNumber { get; set; }
    public DateTime? ExpiryDate { get; set; }
    public DateTime? ProductionDate { get; set; }
    public int Quantity { get; set; }
    public decimal? Price { get; set; }
    public int WarehouseID { get; set; }
    public int SupplierID { get; set; }

}
