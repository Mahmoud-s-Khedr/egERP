namespace Backend.Models;
public class EmployeeTraining
{
    public int EmployeeTrainingID { get; set; }
    public int EmployeeID { get; set; }
    public int ProgramID { get; set; }
    public DateTime? CompletionDate { get; set; }
    public DateTime StartDate { get; set; }
    public EmployeeTrainingStatus CompletionStatus { get; set; }
}

public enum EmployeeTrainingStatus
{
    Completed=1,
    InProgress,
    NotStarted
}
