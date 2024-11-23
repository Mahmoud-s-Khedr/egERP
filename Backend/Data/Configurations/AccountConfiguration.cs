using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Backend.Models;
public class AccountConfiguration : IEntityTypeConfiguration<Account>
{
    public void Configure(EntityTypeBuilder<Account> builder)
    {
        // Set the primary key
        builder.HasKey(a => a.AccountID);
        // Map the table name to "Accounts"
        builder.ToTable("Accounts");

        // Map the AccountID property to the "AccountID" column
        builder.Property(a => a.AccountID)
               .HasColumnName("AccountID")
               .ValueGeneratedOnAdd(); // Auto-incremented (Identity column)

        // Map the AccountName property to the "AccountName" column
        builder.Property(a => a.AccountName)
               .HasColumnName("AccountName")
               .IsRequired() // AccountName is required (NOT NULL)
               .HasMaxLength(100);

        // Map the AccountType property to the "AccountType" column
        builder.Property(a => a.AccountType)
               .HasColumnName("AccountType")
               .IsRequired() // AccountType is required (NOT NULL)
               .HasMaxLength(50); // For ENUM values (Asset, Liability, etc.)

        // Map the Balance property to the "Balance" column
        builder.Property(a => a.Balance)
               .HasColumnName("Balance")
               .HasColumnType("DECIMAL(15, 2)") // Balance has two decimal places
               .HasDefaultValue(0); // Default value for Balance is 0
    }
}
