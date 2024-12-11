namespace Backend.Models;
public class Warehouse
{
    public int WarehouseID { get; set; }
    public string? WarehouseName { get; set; }
    public bool IsActive { get; set; } = true;
}
