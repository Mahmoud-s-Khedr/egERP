namespace Backend.Models;
public class PurchaseOrder
{
    public int PurchaseOrderID { get; set; }
    public int SupplierID { get; set; }
    public DateTime OrderDate { get; set; }
    public decimal? TotalAmount { get; set; }
    public PurchaseOrderStatus PurchaseOrderStatus { get; set; } = PurchaseOrderStatus.Pending;

}

public enum PurchaseOrderStatus{
    Pending=1,
    Received,
    Completed
}
