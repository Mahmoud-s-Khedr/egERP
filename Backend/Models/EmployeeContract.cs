namespace Backend.Models;
public class EmployeeContract
{
    public int ContractID { get; set; }
    public int EmployeeID { get; set; }
    public DateTime ContractStartDate { get; set; }
    public DateTime ContractEndDate { get; set; }
    public ContractType ContractType { get; set; }
    public string ContractDescription { get; set; }
    public EmployeeContractStatus ContractStatus { get; set; }
}

public enum ContractType
{
    FullTime=0,
    PartTime,
    Internship
}

public enum EmployeeContractStatus
{
    Active=0,
    Inactive
}
