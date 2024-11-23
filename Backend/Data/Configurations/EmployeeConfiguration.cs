using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Backend.Models;
public class EmployeeConfiguration : IEntityTypeConfiguration<Employee>
{
    public void Configure(EntityTypeBuilder<Employee> builder)
    {
        // Set the primary key
        builder.HasKey(e => e.EmployeeID);
        // Map the table name to "Employees"
        builder.ToTable("Employees");

        // Map the EmployeeID property to the "EmployeeID" column
        builder.Property(e => e.EmployeeID)
               .HasColumnName("EmployeeID") // Column name in the table
               .IsRequired(); // Auto-incremented (Identity column)

        // Map the FirstName property to the "FirstName" column
        builder.Property(e => e.FirstName)
               .HasColumnName("FirstName")
               .IsRequired() // FirstName is required (NOT NULL)
               .HasMaxLength(50); // Maximum length of 50 characters

        // Map the LastName property to the "LastName" column
        builder.Property(e => e.LastName)
               .HasColumnName("LastName")
               .IsRequired() // LastName is required (NOT NULL)
               .HasMaxLength(50); // Maximum length of 50 characters

        // Map the DepartmentID property to the "DepartmentID" column
        builder.Property(e => e.DepartmentID)
               .HasColumnName("DepartmentID");

        // Map the JobTitle property to the "JobTitle" column
        builder.Property(e => e.JobTitle)
               .HasColumnName("JobTitle")
               .HasMaxLength(100); // Maximum length of 100 characters

        // Map the HireDate property to the "HireDate" column
        builder.Property(e => e.HireDate)
               .HasColumnName("HireDate");

        // Map the Salary property to the "Salary" column
        builder.Property(e => e.Salary)
               .HasColumnName("Salary")
               .HasColumnType("DECIMAL(10, 2)"); // Decimal with 2 precision

        // Map the IsActive property to the "IsActive" column
        builder.Property(e => e.IsActive)
               .HasColumnName("IsActive")
               .HasDefaultValue(true); // Default value TRUE for IsActive

    }
}
