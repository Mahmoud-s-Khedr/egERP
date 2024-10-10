

using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

public class LogInModel
{
    [Required]
    public string? UserName{ get; set; }
    [Required]
    public string? Password { get; set; }
    [JsonIgnore]
    public int EmployeeId { get; set; }
}