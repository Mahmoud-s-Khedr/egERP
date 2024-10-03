using System.Text.Json.Serialization;

public class CustomerContact{
    public int Id {set;get;}
    public int CustomerId{set;get;}
    public string? Contact{set;get;} 
    [JsonIgnore]
    public Customer? Customer{set; get;}
}