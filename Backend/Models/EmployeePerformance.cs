namespace Backend.Models;
public class EmployeePerformance
{
    public int PerformanceID { get; set; }
    public int EmployeeID { get; set; }
    public DateTime ReviewDate { get; set; }
    public int PerformanceRating { get; set; }
    public string PerformanceComments { get; set; }
    public int SupervisorID { get; set; }
}
