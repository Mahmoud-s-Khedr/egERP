namespace Backend.Models;
public class EmployeeBankAccount
{
    public int BankAccountID { get; set; }
    public int EmployeeID { get; set; }
    public string BankName { get; set; }
    public string AccountNumber { get; set; }
}
