using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Backend.Models;
public class OpportunityConfiguration : IEntityTypeConfiguration<Opportunity>
{
    public void Configure(EntityTypeBuilder<Opportunity> builder)
    {
        // Set the primary key
        builder.HasKey(o => o.OpportunityID);
        // Map the table name to "Opportunities"
        builder.ToTable("Opportunities");

        // Map the OpportunityID property to the "OpportunityID" column
        builder.Property(o => o.OpportunityID)
               .HasColumnName("OpportunityID") // Column name in the table
               .ValueGeneratedOnAdd(); // Auto-incremented (Identity column)

        // Map the CustomerID property to the "CustomerID" column
        builder.Property(o => o.CustomerID)
               .HasColumnName("CustomerID")
               .IsRequired(); // CustomerID is required (NOT NULL)

        // Map the OpportunityName property to the "OpportunityName" column
        builder.Property(o => o.OpportunityName)
               .HasColumnName("OpportunityName")
               .HasMaxLength(100); // Max length of 100 characters

        // Map the EstimatedValue property to the "EstimatedValue" column
        builder.Property(o => o.EstimatedValue)
               .HasColumnName("EstimatedValue")
               .HasColumnType("DECIMAL(10, 2)"); // Set the column type for decimal

        // Map the CloseDate property to the "CloseDate" column
        builder.Property(o => o.CloseDate)
               .HasColumnName("CloseDate")
               .HasColumnType("DATE"); // Set the column type for date

        // Map the Probability property to the "Probability" column
        builder.Property(o => o.Probability)
               .HasColumnName("Probability")
               .HasColumnType("DECIMAL(3, 2)"); // Set the column type for decimal

        // Map the OpportunityDescription property to the "OpportunityDescription" column
        builder.Property(o => o.OpportunityDescription)
               .HasColumnName("OpportunityDescription")
               .HasColumnType("TEXT"); // Set the column type for text

        // Map the OpportunityStatus property to the "OpportunityStatus" column
        builder.Property(o => o.OpportunityStatus)
               .HasColumnName("OpportunityStatus")
               .HasMaxLength(20) // Max length of the ENUM values
               .HasDefaultValue("Open"); // Default value for OpportunityStatus

    }
}
