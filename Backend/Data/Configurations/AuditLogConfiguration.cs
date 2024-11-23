using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Backend.Models;
public class AuditLogConfiguration : IEntityTypeConfiguration<AuditLog>
{
    public void Configure(EntityTypeBuilder<AuditLog> builder)
    {
        // Set the primary key
        builder.HasKey(x => x.AuditID);
        // Map the table name to "AuditLogs"
        builder.ToTable("AuditLogs");

        // Map the AuditID property to the "AuditID" column
        builder.Property(a => a.AuditID)
               .HasColumnName("AuditID") // Column name in the table
               .ValueGeneratedOnAdd(); // Auto-incremented (Identity column)

        // Map the TableName property to the "TableName" column
        builder.Property(a => a.TableName)
               .HasColumnName("TableName")
               .IsRequired() // TableName is required (NOT NULL)
               .HasMaxLength(100); // Maximum length of 100 characters

        // Map the RecordID property to the "RecordID" column
        builder.Property(a => a.RecordID)
               .HasColumnName("RecordID")
               .IsRequired(); // RecordID is required (NOT NULL)

        // Map the AuditAction property to the "AuditAction" column
        builder.Property(a => a.AuditAction)
               .HasColumnName("AuditAction")
               .IsRequired(); // AuditAction is required (NOT NULL)

        // Map the UserID property to the "UserID" column
        builder.Property(a => a.UserID)
               .HasColumnName("UserID");

        // Map the ActionTime property to the "ActionTime" column
        builder.Property(a => a.ActionTime)
               .HasColumnName("ActionTime")
               .HasDefaultValueSql("CURRENT_TIMESTAMP"); // Default value for ActionTime

        // Map the Reason property to the "Reason" column
        builder.Property(a => a.Reason)
               .HasColumnName("Reason")
               .HasColumnType("TEXT"); // Reason as a text column type
    }
}
