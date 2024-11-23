namespace Backend.Models;
public class TrainingProgram
{
    public int ProgramID { get; set; }
    public string ProgramName { get; set; }
    public string TrainingProgramDescription { get; set; }
    public decimal TrainingProgramCost { get; set; }
    public DateTime StartDate { get; set; }
    public DateTime EndDate { get; set; }
    public TrainingProgramStatus TrainingProgramStatus { get; set; }
    public string TrainingProvider { get; set; }
    public string TrainerName { get; set; }
}

public enum TrainingProgramStatus
{
    Active=1,
    Completed,
    Cancelled
}
