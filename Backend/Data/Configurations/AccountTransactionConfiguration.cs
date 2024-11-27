using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Backend.Models;
public class AccountTransactionConfiguration : IEntityTypeConfiguration<AccountTransaction>
{
    public void Configure(EntityTypeBuilder<AccountTransaction> builder)
    {
        // Set the primary key
        builder.HasKey(at => at.TransactionID);
        // Map the table name to "AccountTransactions"
        builder.ToTable("AccountTransactions");

              // Map the TransactionID property to the "TransactionID" column
              builder.Property(at => at.TransactionID)
                     .HasColumnName("TransactionID");

        // Map the AccountID property to the "AccountID" column
        builder.Property(at => at.AccountID)
               .HasColumnName("AccountID")
               .IsRequired(); // AccountID is required (NOT NULL)

        // Map the TransactionDate property to the "TransactionDate" column
        builder.Property(at => at.TransactionDate)
               .HasColumnName("TransactionDate")
               .HasColumnType("DATETIME")
               .HasDefaultValueSql("CURRENT_TIMESTAMP"); // Default value is current timestamp

        // Map the Amount property to the "Amount" column
        builder.Property(at => at.Amount)
               .HasColumnName("Amount")
               .HasColumnType("DECIMAL(15, 2)") // Amount has two decimal places
               .IsRequired(); // Amount is required

        // Map the AccountTransactionDescription property to the "AccountTransactionDescription" column
        builder.Property(at => at.AccountTransactionDescription)
               .HasColumnName("AccountTransactionDescription")
               .HasColumnType("TEXT"); // Optional description

    }
}
