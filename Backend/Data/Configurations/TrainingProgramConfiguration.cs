using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Backend.Models;
public class TrainingProgramConfiguration : IEntityTypeConfiguration<TrainingProgram>
{
    public void Configure(EntityTypeBuilder<TrainingProgram> builder)
    {
        // Set the primary key
        builder.HasKey(tp => tp.ProgramID);
        // Map the table name to "TrainingPrograms"
        builder.ToTable("TrainingPrograms");

        // Map the ProgramID property to the "ProgramID" column
        builder.Property(tp => tp.ProgramID)
               .HasColumnName("ProgramID") // Column name in the table
               .ValueGeneratedOnAdd(); // Auto-incremented (Identity column)

        // Map the ProgramName property to the "ProgramName" column
        builder.Property(tp => tp.ProgramName)
               .HasColumnName("ProgramName")
               .HasMaxLength(100) // Max length of 100 characters
               .IsRequired(); // ProgramName is required (NOT NULL)

        // Map the TrainingProgramDescription property to the "TrainingProgramDescription" column
        builder.Property(tp => tp.TrainingProgramDescription)
               .HasColumnName("TrainingProgramDescription");

        // Map the TrainingProgramCost property to the "TrainingProgramCost" column
        builder.Property(tp => tp.TrainingProgramCost)
               .HasColumnName("TrainingProgramCost")
               .HasColumnType("DECIMAL(10, 2)") // Training program cost with 2 decimal places
               .IsRequired(); // TrainingProgramCost is required (NOT NULL)

        // Map the StartDate property to the "StartDate" column
        builder.Property(tp => tp.StartDate)
               .HasColumnName("StartDate")
               .IsRequired(); // StartDate is required (NOT NULL)

        // Map the EndDate property to the "EndDate" column
        builder.Property(tp => tp.EndDate)
               .HasColumnName("EndDate")
               .IsRequired(); // EndDate is required (NOT NULL)

        // Map the TrainingProgramStatus property to the "TrainingProgramStatus" column
        builder.Property(tp => tp.TrainingProgramStatus)
               .HasColumnName("TrainingProgramStatus")
               .HasDefaultValue(TrainingProgramStatus.Active); // Default value is 'Active'

        // Map the TrainingProvider property to the "TrainingProvider" column
        builder.Property(tp => tp.TrainingProvider)
               .HasColumnName("TrainingProvider")
               .HasMaxLength(100) // Max length of 100 characters
               .IsRequired(); // TrainingProvider is required (NOT NULL)

        // Map the TrainerName property to the "TrainerName" column
        builder.Property(tp => tp.TrainerName)
               .HasColumnName("TrainerName")
               .HasMaxLength(100) // Max length of 100 characters
               .IsRequired(); // TrainerName is required (NOT NULL)
    }
}
