namespace Backend.Models;
public class Order
{
    public int OrderID { get; set; }
    public int CustomerID { get; set; }
    public DateTime OrderDate { get; set; }
    public OrderStatus OrderStatus { get; set; } = OrderStatus.Pending;
    public decimal TotalAmount { get; set; }

}

public enum OrderStatus{
    Pending=1,
    Shipped,
    Completed,
    Cancelled
}
