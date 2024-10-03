using System.Text.Json.Serialization;
using Microsoft.AspNetCore.SignalR;
using Microsoft.Net.Http.Headers;

public class CustomerInternalNote{
    public int Id{set;get;}
    public int CustomerId{set;get;}
    public int EmployeeId{set;get;}
    public string ? Note{set;get;}
    public DateTime Date{set;get;}
    [JsonIgnore]
    private Customer ?Customer{set;get;}
}