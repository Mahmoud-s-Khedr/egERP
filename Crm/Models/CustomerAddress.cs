using System.Text.Json.Serialization;

public class CustomerAddress{
    public int Id {set; get;}
    public int CustomerId{set;get;}
    public string ?Address{set; get;}
    public string? City{set;get;}
    
    public string?Country{set;get;}
    public int ZipCode{set;get;}
    public string ?State{set;get;}
    public bool Availabilty{set;get;}
    [JsonIgnore]
    public Customer? Customer{set;get;}
}