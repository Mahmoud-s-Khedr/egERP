namespace Backend.Models;
public class Payroll
{
    public int PayrollID { get; set; }
    public int EmployeeID { get; set; }
    public DateTime PayDate { get; set; }
    public decimal BaseSalary { get; set; }
    public decimal Bonuses { get; set; }
    public decimal Deductions { get; set; }
    public decimal GrossPay { get; set; } // Calculated column (BaseSalary + Bonuses - Deductions)
    public decimal Taxes { get; set; }
    public decimal NetPay { get; set; } // Calculated column (GrossPay - Taxes)

}