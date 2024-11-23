namespace Backend.Models;
public class EmployeeBenefit
{
    public int BenefitID { get; set; }
    public int EmployeeID { get; set; }
    public string BenefitName { get; set; }
    public decimal? BenefitAmount { get; set; }
    public string BenefitDescription { get; set; }
    public BenefitType BenefitType { get; set; }
    public bool IsActive { get; set; }
}

public enum BenefitType
{
    Health=1,
    Dental,
    Vision
}
