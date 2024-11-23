namespace Backend.Models;

public class InventoryTransaction
{
    public int TransactionID { get; set; }
    public int ProductID { get; set; }
    public TransactionType TransactionType { get; set; }
    public int Quantity { get; set; }
    public DateTime TransactionDate { get; set; }

}
public enum TransactionType
{
    IN = 1,
    OUT,
    ADJUSTMENT
}