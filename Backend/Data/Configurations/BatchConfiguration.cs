using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Backend.Models;
public class BatchConfiguration : IEntityTypeConfiguration<Batch>
{
    public void Configure(EntityTypeBuilder<Batch> builder)
    {
        // Set the primary key
        builder.HasKey(x => x.BatchID);
        // Map the table name to "Batches"
        builder.ToTable("Batches");

        // Map the BatchID property to the "BatchID" column
        builder.Property(b => b.BatchID)
               .HasColumnName("BatchID") // Column name in the table
               .ValueGeneratedOnAdd(); // Auto-incremented (Identity column)

        // Map the ProductID property to the "ProductID" column
        builder.Property(b => b.ProductID)
               .HasColumnName("ProductID")
               .IsRequired(); // ProductID is required (NOT NULL)

        // Map the BatchNumber property to the "BatchNumber" column
        builder.Property(b => b.BatchNumber)
               .HasColumnName("BatchNumber")
               .IsRequired() // BatchNumber is required (NOT NULL)
               .HasMaxLength(50); // Max length of 50 characters

        // Map the ExpiryDate property to the "ExpiryDate" column
        builder.Property(b => b.ExpiryDate)
               .HasColumnName("ExpiryDate")
               .HasColumnType("DATE"); // ExpiryDate as date type

        // Map the ProductionDate property to the "ProductionDate" column
        builder.Property(b => b.ProductionDate)
               .HasColumnName("ProductionDate")
               .HasColumnType("DATE"); // ProductionDate as date type

        // Map the Quantity property to the "Quantity" column
        builder.Property(b => b.Quantity)
               .HasColumnName("Quantity")
               .IsRequired(); // Quantity is required (NOT NULL)

        // Map the Price property to the "Price" column
        builder.Property(b => b.Price)
               .HasColumnName("Price")
               .HasColumnType("DECIMAL(10, 2)"); // Price as decimal with 2 decimal places

        // Map the WarehouseID property to the "WarehouseID" column
        builder.Property(b => b.WarehouseID)
               .HasColumnName("WarehouseID")
               .IsRequired(); // WarehouseID is required (NOT NULL)
        builder.Property(b => b.SupplierID)
                .HasColumnName("SupplierID")
                .IsRequired();
    }
}
