using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Backend.Models;
public class EmployeeTrainingConfiguration : IEntityTypeConfiguration<EmployeeTraining>
{
    public void Configure(EntityTypeBuilder<EmployeeTraining> builder)
    {
        // Set primary key
        builder.HasKey(et => et.EmployeeTrainingID);
        // Map the table name to "EmployeeTraining"
        builder.ToTable("EmployeeTraining");

        // Map the EmployeeTrainingID property to the "EmployeeTrainingID" column
        builder.Property(et => et.EmployeeTrainingID)
               .HasColumnName("EmployeeTrainingID") // Column name in the table
               .ValueGeneratedOnAdd(); // Auto-incremented (Identity column)

        // Map the EmployeeID property to the "EmployeeID" column
        builder.Property(et => et.EmployeeID)
               .HasColumnName("EmployeeID")
               .IsRequired(); // EmployeeID is required (NOT NULL)

        // Map the ProgramID property to the "ProgramID" column
        builder.Property(et => et.ProgramID)
               .HasColumnName("ProgramID")
               .IsRequired(); // ProgramID is required (NOT NULL)

        // Map the CompletionDate property to the "CompletionDate" column
        builder.Property(et => et.CompletionDate)
               .HasColumnName("CompletionDate");
        // Map the CompletionDate property to the "StartDate" column
        builder.Property(et => et.StartDate)
               .HasColumnName("StartDate");
        // Map the CompletionStatus property to the "CompletionStatus" column
        builder.Property(et => et.CompletionStatus)
               .HasColumnName("CompletionStatus")
               .HasDefaultValue(EmployeeTrainingStatus.NotStarted); // Default value is 'Not Started'

    }
}
