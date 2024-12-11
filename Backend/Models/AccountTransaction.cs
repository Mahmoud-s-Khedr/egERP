namespace Backend.Models;
public class AccountTransaction
{
    public int TransactionID { get; set; }
    public int AccountID { get; set; }
    public DateTime TransactionDate { get; set; }
    public decimal Amount { get; set; }
    public string? AccountTransactionDescription { get; set; }

}
