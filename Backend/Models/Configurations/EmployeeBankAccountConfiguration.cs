using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Backend.Models;
public class EmployeeBankAccountConfiguration : IEntityTypeConfiguration<EmployeeBankAccount>
{
    public void Configure(EntityTypeBuilder<EmployeeBankAccount> builder)
    {
        //Set the primary key
        builder.HasKey(eba => eba.BankAccountID);
        // Map the table name to "EmployeeBankAccounts"
        builder.ToTable("EmployeeBankAccounts");

        // Map the BankAccountID property to the "BankAccountID" column
        builder.Property(eba => eba.BankAccountID)
               .HasColumnName("BankAccountID") // Column name in the table
               .ValueGeneratedOnAdd(); // Auto-incremented (Identity column)

        // Map the EmployeeID property to the "EmployeeID" column
        builder.Property(eba => eba.EmployeeID)
               .HasColumnName("EmployeeID")
               .IsRequired(); // EmployeeID is required (NOT NULL)

        // Map the BankName property to the "BankName" column
        builder.Property(eba => eba.BankName)
               .HasColumnName("BankName")
               .HasMaxLength(100); // Max length of 100 characters

        // Map the AccountNumber property to the "AccountNumber" column
        builder.Property(eba => eba.AccountNumber)
               .HasColumnName("AccountNumber")
               .HasMaxLength(50); // Max length of 50 characters
    }
}
