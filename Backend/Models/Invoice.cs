namespace Backend.Models;
public class Invoice
{
    public int InvoiceID { get; set; }
    public int OrderID { get; set; }
    public DateTime InvoiceDate { get; set; }
    public DateTime? DueDate { get; set; }
    public decimal TotalAmount { get; set; }
    public decimal PaidAmount { get; set; }


}
