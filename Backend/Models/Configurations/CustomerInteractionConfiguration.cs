using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Backend.Models;
public class CustomerInteractionConfiguration : IEntityTypeConfiguration<CustomerInteraction>
{
    public void Configure(EntityTypeBuilder<CustomerInteraction> builder)
    {
        // Set the primary key
        builder.HasKey(ci => ci.InteractionID);
        // Map the table name to "CustomerInteractions"
        builder.ToTable("CustomerInteractions");

        // Map the InteractionID property to the "InteractionID" column
        builder.Property(ci => ci.InteractionID)
               .HasColumnName("InteractionID")
               .ValueGeneratedOnAdd(); // Auto-incremented (Identity column)

        // Map the CustomerID property to the "CustomerID" column
        builder.Property(ci => ci.CustomerID)
               .HasColumnName("CustomerID")
               .IsRequired(); // CustomerID is required (NOT NULL)

        // Map the InteractionDate property to the "InteractionDate" column
        builder.Property(ci => ci.InteractionDate)
               .HasColumnName("InteractionDate")
               .HasColumnType("DATETIME")
               .HasDefaultValueSql("CURRENT_TIMESTAMP"); // Default value is current timestamp

        // Map the InteractionType property to the "InteractionType" column
        builder.Property(ci => ci.InteractionType)
               .HasColumnName("InteractionType")
               .HasColumnType("ENUM('Email', 'Phone', 'In-Person', 'Other')")
               .IsRequired(); // InteractionType is required

        // Map the Notes property to the "Notes" column
        builder.Property(ci => ci.Notes)
               .HasColumnName("Notes")
               .HasColumnType("TEXT"); // Optional notes

    }
}
