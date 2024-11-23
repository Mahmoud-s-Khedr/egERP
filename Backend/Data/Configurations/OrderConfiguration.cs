using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Backend.Models;
public class OrderConfiguration : IEntityTypeConfiguration<Order>
{
    public void Configure(EntityTypeBuilder<Order> builder)
    {
        // Set the primary key
        builder.HasKey(o => o.OrderID);
        // Map the table name to "Orders"
        builder.ToTable("Orders");

        // Map the OrderID property to the "OrderID" column
        builder.Property(o => o.OrderID)
               .HasColumnName("OrderID") // Column name in the table
               .ValueGeneratedOnAdd(); // Auto-incremented (Identity column)

        // Map the CustomerID property to the "CustomerID" column
        builder.Property(o => o.CustomerID)
               .HasColumnName("CustomerID")
               .IsRequired(); // CustomerID is required (NOT NULL)

        // Map the OrderDate property to the "OrderDate" column
        builder.Property(o => o.OrderDate)
               .HasColumnName("OrderDate")
               .HasDefaultValueSql("CURRENT_TIMESTAMP"); // Default value for OrderDate is current timestamp

        // Map the OrderStatus property to the "OrderStatus" column
        builder.Property(o => o.OrderStatus)
               .HasColumnName("OrderStatus")
               .HasDefaultValue("Pending"); // Default value is "Pending"

        // Map the TotalAmount property to the "TotalAmount" column
        builder.Property(o => o.TotalAmount)
               .HasColumnName("TotalAmount")
               .HasColumnType("DECIMAL(10, 2)"); // Set column type for TotalAmount

    }
}
