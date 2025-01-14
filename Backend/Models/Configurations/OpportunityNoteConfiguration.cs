using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Backend.Models;
public class OpportunityNoteConfiguration : IEntityTypeConfiguration<OpportunityNote>
{
    public void Configure(EntityTypeBuilder<OpportunityNote> builder)
    {
        // Set the primary key
        builder.HasKey(x => x.NoteID);
        // Map the table name to "OpportunityNotes"
        builder.ToTable("OpportunityNotes");

        // Map the NoteID property to the "NoteID" column
        builder.Property(on => on.NoteID)
               .HasColumnName("NoteID") // Column name in the table
               .ValueGeneratedOnAdd(); // Auto-incremented (Identity column)

        // Map the OpportunityID property to the "OpportunityID" column
        builder.Property(on => on.OpportunityID)
               .HasColumnName("OpportunityID")
               .IsRequired(); // OpportunityID is required (NOT NULL)

        // Map the NoteDate property to the "NoteDate" column
        builder.Property(on => on.NoteDate)
               .HasColumnName("NoteDate")
               .HasDefaultValueSql("CURRENT_TIMESTAMP"); // Default value for NoteDate is current timestamp

        // Map the NoteText property to the "NoteText" column
        builder.Property(on => on.NoteText)
               .HasColumnName("NoteText")
               .HasColumnType("TEXT") // Set the column type for text
               .IsRequired(); // NoteText is required (NOT NULL)

        // Map the EmployeeID property to the "EmployeeID" column
        builder.Property(on => on.EmployeeID)
               .HasColumnName("EmployeeID")
               .IsRequired(); // EmployeeID is required (NOT NULL)
    }
}
