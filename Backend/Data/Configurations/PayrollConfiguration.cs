using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Backend.Models;
public class PayrollConfiguration : IEntityTypeConfiguration<Payroll>
{
    public void Configure(EntityTypeBuilder<Payroll> builder)
    {
        // set primary key
        builder.HasKey(p => p.PayrollID);
        // Map the table name to "Payroll"
        builder.ToTable("Payroll");

        // Map the PayrollID property to the "PayrollID" column
        builder.Property(p => p.PayrollID)
               .HasColumnName("PayrollID") // Column name in the table
               .ValueGeneratedOnAdd(); // Auto-incremented (Identity column)

        // Map the EmployeeID property to the "EmployeeID" column
        builder.Property(p => p.EmployeeID)
               .HasColumnName("EmployeeID")
               .IsRequired(); // EmployeeID is required (NOT NULL)

        // Map the PayDate property to the "PayDate" column
        builder.Property(p => p.PayDate)
               .HasColumnName("PayDate")
               .IsRequired(); // PayDate is required (NOT NULL)

        // Map the BaseSalary property to the "BaseSalary" column
        builder.Property(p => p.BaseSalary)
               .HasColumnName("BaseSalary")
               .HasColumnType("DECIMAL(10, 2)");

        // Map the Bonuses property to the "Bonuses" column
        builder.Property(p => p.Bonuses)
               .HasColumnName("Bonuses")
               .HasColumnType("DECIMAL(10, 2)");

        // Map the Deductions property to the "Deductions" column
        builder.Property(p => p.Deductions)
               .HasColumnName("Deductions")
               .HasColumnType("DECIMAL(10, 2)");

        // Map the GrossPay property to the "GrossPay" column
        builder.Property(p => p.GrossPay)
               .HasColumnName("GrossPay")
               .HasComputedColumnSql("[BaseSalary] + [Bonuses] - [Deductions]"); // Computed column formula

        // Map the Taxes property to the "Taxes" column
        builder.Property(p => p.Taxes)
               .HasColumnName("Taxes")
               .HasColumnType("DECIMAL(10, 2)");

        // Map the NetPay property to the "NetPay" column
        builder.Property(p => p.NetPay)
               .HasColumnName("NetPay")
               .HasComputedColumnSql("[GrossPay] - [Taxes]"); // Computed column formula
    }
}
