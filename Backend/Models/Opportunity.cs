namespace Backend.Models;
public class Opportunity
{
    public int OpportunityID { get; set; }
    public int CustomerID { get; set; }
    public string? OpportunityName { get; set; }
    public decimal? EstimatedValue { get; set; }
    public DateTime? CloseDate { get; set; }
    public decimal? Probability { get; set; }
    public string? OpportunityDescription { get; set; }
    public OpportunityStatus OpportunityStatus { get; set; } = OpportunityStatus.Open;

}

public enum OpportunityStatus{
    Open=1,
    Won,
    Lost
}