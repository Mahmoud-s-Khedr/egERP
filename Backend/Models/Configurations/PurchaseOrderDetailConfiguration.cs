using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Backend.Models;
public class PurchaseOrderDetailConfiguration : IEntityTypeConfiguration<PurchaseOrderDetail>
{
    public void Configure(EntityTypeBuilder<PurchaseOrderDetail> builder)
    {
        // Set the primary key
        builder.HasKey(pod => pod.PurchaseOrderDetailID);
        // Map the table name to "PurchaseOrderDetails"
        builder.ToTable("PurchaseOrderDetails");

        // Map the PurchaseOrderDetailID property to the "PurchaseOrderDetailID" column
        builder.Property(pod => pod.PurchaseOrderDetailID)
               .HasColumnName("PurchaseOrderDetailID")
               .ValueGeneratedOnAdd(); // Auto-incremented (Identity column)

        // Map the PurchaseOrderID property to the "PurchaseOrderID" column
        builder.Property(pod => pod.PurchaseOrderID)
               .HasColumnName("PurchaseOrderID")
               .IsRequired(); // PurchaseOrderID is required (NOT NULL)

        // Map the ProductID property to the "ProductID" column
        builder.Property(pod => pod.ProductID)
               .HasColumnName("ProductID")
               .IsRequired(); // ProductID is required (NOT NULL)

        // Map the Quantity property to the "Quantity" column
        builder.Property(pod => pod.Quantity)
               .HasColumnName("Quantity")
               .IsRequired(); // Quantity is required (NOT NULL)

        // Map the UnitPrice property to the "UnitPrice" column
        builder.Property(pod => pod.UnitPrice)
               .HasColumnName("UnitPrice")
               .HasColumnType("DECIMAL(10, 2)"); // UnitPrice is nullable
    }
}
