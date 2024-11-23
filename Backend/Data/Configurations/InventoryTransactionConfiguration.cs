using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Backend.Models;
public class InventoryTransactionConfiguration : IEntityTypeConfiguration<InventoryTransaction>
{
    public void Configure(EntityTypeBuilder<InventoryTransaction> builder)
    {
        // Set primary key
        builder.HasKey(x => x.TransactionID);
        // Map the table name to "InventoryTransactions"
        builder.ToTable("InventoryTransactions");

        // Map the TransactionID property to the "TransactionID" column
        builder.Property(it => it.TransactionID)
               .HasColumnName("TransactionID") // Column name in the table
               .ValueGeneratedOnAdd(); // Auto-incremented (Identity column)

        // Map the ProductID property to the "ProductID" column
        builder.Property(it => it.ProductID)
               .HasColumnName("ProductID")
               .IsRequired(); // ProductID is required (NOT NULL)

        // Map the TransactionType property to the "TransactionType" column
        builder.Property(it => it.TransactionType)
               .HasColumnName("TransactionType")
               .IsRequired(); // TransactionType is required (NOT NULL)

        // Map the Quantity property to the "Quantity" column
        builder.Property(it => it.Quantity)
               .HasColumnName("Quantity")
               .IsRequired(); // Quantity is required (NOT NULL)

        // Map the TransactionDate property to the "TransactionDate" column
        builder.Property(it => it.TransactionDate)
               .HasColumnName("TransactionDate")
               .HasColumnType("DATETIME")
               .HasDefaultValueSql("CURRENT_TIMESTAMP"); // Default value set to the current timestamp
    }
}
