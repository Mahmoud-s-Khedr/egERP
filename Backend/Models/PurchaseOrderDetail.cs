namespace Backend.Models;
public class PurchaseOrderDetail
{
    public int PurchaseOrderDetailID { get; set; }
    public int PurchaseOrderID { get; set; }
    public int ProductID { get; set; }
    public int Quantity { get; set; }
    public decimal? UnitPrice { get; set; }

}
