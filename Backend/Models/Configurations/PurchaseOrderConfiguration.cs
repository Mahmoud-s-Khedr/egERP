using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Backend.Models;
public class PurchaseOrderConfiguration : IEntityTypeConfiguration<PurchaseOrder>
{
    public void Configure(EntityTypeBuilder<PurchaseOrder> builder)
    {
        // Set the primary key
        builder.HasKey(po => po.PurchaseOrderID);
        // Map the table name to "PurchaseOrders"
        builder.ToTable("PurchaseOrders");

        // Map the PurchaseOrderID property to the "PurchaseOrderID" column
        builder.Property(po => po.PurchaseOrderID)
               .HasColumnName("PurchaseOrderID")
               .ValueGeneratedOnAdd(); // Auto-incremented (Identity column)

        // Map the SupplierID property to the "SupplierID" column
        builder.Property(po => po.SupplierID)
               .HasColumnName("SupplierID")
               .IsRequired(); // SupplierID is required (NOT NULL)

        // Map the OrderDate property to the "OrderDate" column
        builder.Property(po => po.OrderDate)
               .HasColumnName("OrderDate")
               .HasDefaultValueSql("CURRENT_TIMESTAMP") // Default value
               .IsRequired(); // OrderDate is required (NOT NULL)

        // Map the TotalAmount property to the "TotalAmount" column
        builder.Property(po => po.TotalAmount)
               .HasColumnName("TotalAmount")
               .HasColumnType("DECIMAL(10, 2)")
               .IsRequired(false); // TotalAmount is nullable

        // Map the PurchaseOrderStatus property to the "PurchaseOrderStatus" column
        builder.Property(po => po.PurchaseOrderStatus)
               .HasColumnName("PurchaseOrderStatus")
               .IsRequired(); // PurchaseOrderStatus is required (NOT NULL)
    }
}
