namespace Backend.Models;
public class CustomerInteraction
{
    public int InteractionID { get; set; }
    public int CustomerID { get; set; }
    public DateTime InteractionDate { get; set; }
    public InteractionType InteractionType { get; set; }
    public string? Notes { get; set; }

}
public enum InteractionType{
    Email=1,
    Phone,
    InPerson,
    Other
}