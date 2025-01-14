using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Backend.Models;

public class DepartmentConfiguration : IEntityTypeConfiguration<Department>
{
    public void Configure(EntityTypeBuilder<Department> builder)
    {
        // Set the primary key
        builder.HasKey(x => x.DepartmentID);
        // Map the table name to "Departments"
        builder.ToTable("Departments");

        // Map the DepartmentID property to the "DepartmentID" column
        builder.Property(d => d.DepartmentID)
               .HasColumnName("DepartmentID") // Column name in the table
               .IsRequired(); // Auto-incremented (Identity column)

        // Map the DepartmentName property to the "DepartmentName" column
        builder.Property(d => d.DepartmentName)
               .HasColumnName("DepartmentName") // Column name in the table
               .IsRequired() // DepartmentName is required (NOT NULL)
               .HasMaxLength(100); // Maximum length of 100 characters
    }
}
