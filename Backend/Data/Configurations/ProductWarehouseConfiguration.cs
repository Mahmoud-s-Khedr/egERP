using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Backend.Models;
public class ProductWarehouseConfiguration : IEntityTypeConfiguration<ProductWarehouse>
{
    public void Configure(EntityTypeBuilder<ProductWarehouse> builder)
    {
        // Set the primary key
        builder.HasKey(x => x.ProductWarehouseID);
        // Map the table name to "ProductWarehouses"
        builder.ToTable("ProductWarehouses");

        // Map the ProductWarehouseID property to the "ProductWarehouseID" column
        builder.Property(pw => pw.ProductWarehouseID)
               .HasColumnName("ProductWarehouseID") // Column name in the table
               .ValueGeneratedOnAdd(); // Auto-incremented (Identity column)

        // Map the ProductID property to the "ProductID" column
        builder.Property(pw => pw.ProductID)
               .HasColumnName("ProductID")
               .IsRequired(); // ProductID is required (NOT NULL)

        // Map the WarehouseID property to the "WarehouseID" column
        builder.Property(pw => pw.WarehouseID)
               .HasColumnName("WarehouseID")
               .IsRequired(); // WarehouseID is required (NOT NULL)

        // Map the Quantity property to the "Quantity" column
        builder.Property(pw => pw.Quantity)
               .HasColumnName("Quantity")
               .IsRequired(); // Quantity is required (NOT NULL)

    }
}
