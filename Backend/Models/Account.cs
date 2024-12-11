namespace Backend.Models;
public class Account
{
    public int AccountID { get; set; }
    public string? AccountName { get; set; }
    public AccountType AccountType { get; set; }
    public decimal Balance { get; set; }
}

public enum AccountType{
    Asset=1,
    Liability,
    Equity,
    Revenue,
    Expense
}
