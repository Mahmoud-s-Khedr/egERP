namespace Backend.Models;
public class Product
{
    public int ProductID { get; set; }
    public string ProductName { get; set; }
    public string ProductModel { get; set; }
    public decimal? UnitPrice { get; set; }
    public int QuantityInStock { get; set; }
    public int? CategoryID { get; set; }

}
