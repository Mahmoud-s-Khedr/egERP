using System.Text.Json.Serialization;

public class Customer{
    public int Id{set; get;}
    public string? FirstName{set;get;}
    public string? LastName{set; get;}
    public string? Email{set;get;} 

    
    public List<CustomerContact> CustomerContacts{set;get;}=new List<CustomerContact>(); 
    [JsonIgnore]
    public List<CustomerInternalNote> customerInternalNotes{set; get;}=new List<CustomerInternalNote>();
    
    public List<CustomerAddress> CustomerAddresses{set;get;} = new List<CustomerAddress>();
}