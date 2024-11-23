using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Backend.Models;
public class EmployeePerformanceConfiguration : IEntityTypeConfiguration<EmployeePerformance>
{
    public void Configure(EntityTypeBuilder<EmployeePerformance> builder)
    {
       // Set the primary key
        builder.HasKey(ep => ep.PerformanceID);
        // Map the table name to "EmployeePerformance"
        builder.ToTable("EmployeePerformance");

        // Map the PerformanceID property to the "PerformanceID" column
        builder.Property(ep => ep.PerformanceID)
               .HasColumnName("PerformanceID") // Column name in the table
               .ValueGeneratedOnAdd(); // Auto-incremented (Identity column)

        // Map the EmployeeID property to the "EmployeeID" column
        builder.Property(ep => ep.EmployeeID)
               .HasColumnName("EmployeeID")
               .IsRequired(); // EmployeeID is required (NOT NULL)

        // Map the ReviewDate property to the "ReviewDate" column
        builder.Property(ep => ep.ReviewDate)
               .HasColumnName("ReviewDate")
               .IsRequired(); // ReviewDate is required (NOT NULL)

        // Map the PerformanceRating property to the "PerformanceRating" column
        builder.Property(ep => ep.PerformanceRating)
               .HasColumnName("PerformanceRating")
               .IsRequired(); // PerformanceRating is required (NOT NULL)

        // Map the PerformanceComments property to the "PerformanceComments" column
        builder.Property(ep => ep.PerformanceComments)
               .HasColumnName("PerformanceComments");

        // Map the SupervisorID property to the "SupervisorID" column
        builder.Property(ep => ep.SupervisorID)
               .HasColumnName("SupervisorID")
               .IsRequired(); // SupervisorID is required (NOT NULL)

    }
}
