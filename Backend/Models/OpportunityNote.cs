namespace Backend.Models;
public class OpportunityNote
{
    public int NoteID { get; set; }
    public int OpportunityID { get; set; }
    public DateTime NoteDate { get; set; }
    public string NoteText { get; set; }
    public int EmployeeID { get; set; }

}
