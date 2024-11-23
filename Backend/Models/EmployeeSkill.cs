namespace Backend.Models;
public class EmployeeSkill
{
    public int EmployeeSkillID { get; set; }
    public int EmployeeID { get; set; }
    public int SkillID { get; set; }
    public ProficiencyLevel ProficiencyLevel { get; set; }
}

public enum ProficiencyLevel
{
    Beginner=1,
    Intermediate,
    Expert
}
