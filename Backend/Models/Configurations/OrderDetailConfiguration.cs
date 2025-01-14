using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Backend.Models;
public class OrderDetailConfiguration : IEntityTypeConfiguration<OrderDetail>
{
    public void Configure(EntityTypeBuilder<OrderDetail> builder)
    {
        // Set the primary key
        builder.HasKey(od => od.OrderDetailID);
        // Map the table name to "OrderDetails"
        builder.ToTable("OrderDetails");

        // Map the OrderDetailID property to the "OrderDetailID" column
        builder.Property(od => od.OrderDetailID)
               .HasColumnName("OrderDetailID") // Column name in the table
               .ValueGeneratedOnAdd(); // Auto-incremented (Identity column)

        // Map the OrderID property to the "OrderID" column
        builder.Property(od => od.OrderID)
               .HasColumnName("OrderID")
               .IsRequired(); // OrderID is required (NOT NULL)

        // Map the ProductID property to the "ProductID" column
        builder.Property(od => od.ProductID)
               .HasColumnName("ProductID")
               .IsRequired(); // ProductID is required (NOT NULL)

        // Map the Quantity property to the "Quantity" column
        builder.Property(od => od.Quantity)
               .HasColumnName("Quantity")
               .IsRequired(); // Quantity is required (NOT NULL)

        // Map the UnitPrice property to the "UnitPrice" column
        builder.Property(od => od.UnitPrice)
               .HasColumnName("UnitPrice")
               .HasColumnType("DECIMAL(10, 2)"); // Set column type for UnitPrice

    }
}
