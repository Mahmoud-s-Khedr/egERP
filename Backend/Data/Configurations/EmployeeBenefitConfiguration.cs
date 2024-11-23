using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Backend.Models;
public class EmployeeBenefitConfiguration : IEntityTypeConfiguration<EmployeeBenefit>
{
    public void Configure(EntityTypeBuilder<EmployeeBenefit> builder)
    {
        // set primary key
        builder.HasKey(eb => eb.BenefitID);
        // Map the table name to "EmployeeBenefits"
        builder.ToTable("EmployeeBenefits");

        // Map the BenefitID property to the "BenefitID" column
        builder.Property(eb => eb.BenefitID)
               .HasColumnName("BenefitID") // Column name in the table
               .ValueGeneratedOnAdd(); // Auto-incremented (Identity column)

        // Map the EmployeeID property to the "EmployeeID" column
        builder.Property(eb => eb.EmployeeID)
               .HasColumnName("EmployeeID")
               .IsRequired(); // EmployeeID is required (NOT NULL)

        // Map the BenefitName property to the "BenefitName" column
        builder.Property(eb => eb.BenefitName)
               .HasColumnName("BenefitName")
               .HasMaxLength(100) // Max length of 100 characters
               .IsRequired(); // BenefitName is required (NOT NULL)

        // Map the BenefitAmount property to the "BenefitAmount" column
        builder.Property(eb => eb.BenefitAmount)
               .HasColumnName("BenefitAmount")
               .HasColumnType("DECIMAL(10, 2)"); // Benefit amount with 2 decimal places

        // Map the BenefitDescription property to the "BenefitDescription" column
        builder.Property(eb => eb.BenefitDescription)
               .HasColumnName("BenefitDescription");

        // Map the BenefitType property to the "BenefitType" column
        builder.Property(eb => eb.BenefitType)
               .HasColumnName("BenefitType")
               .HasConversion(
                    v => v.ToString(),
                    v => (BenefitType)Enum.Parse(typeof(BenefitType), v))
               .IsRequired(); // BenefitType is required (NOT NULL)

        // Map the IsActive property to the "IsActive" column
        builder.Property(eb => eb.IsActive)
               .HasColumnName("IsActive")
               .HasDefaultValue(true); // Default value for IsActive is true

    }
}
