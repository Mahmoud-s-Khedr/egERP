using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Backend.Models;
public class ProductConfiguration : IEntityTypeConfiguration<Product>
{
    public void Configure(EntityTypeBuilder<Product> builder)
    {
        // Map the table name to "Products"
        builder.ToTable("Products");

        // Map the ProductID property to the "ProductID" column
        builder.Property(p => p.ProductID)
               .HasColumnName("ProductID") // Column name in the table
               .ValueGeneratedOnAdd(); // Auto-incremented (Identity column)

        // Map the ProductName property to the "ProductName" column
        builder.Property(p => p.ProductName)
               .HasColumnName("ProductName")
               .IsRequired() // ProductName is required (NOT NULL)
               .HasMaxLength(100); // Max length of 100 characters

        // Map the SKU property to the "SKU" column
        builder.Property(p => p.ProductModel)
               .HasColumnName("ProductModel")
               .IsRequired() // SKU is required (NOT NULL)
               .HasMaxLength(50); // Max length of 50 characters

        // Map the UnitPrice property to the "UnitPrice" column
        builder.Property(p => p.UnitPrice)
               .HasColumnName("UnitPrice")
               .HasColumnType("DECIMAL(10, 2)"); // UnitPrice as decimal with 2 decimal places

        // Map the QuantityInStock property to the "QuantityInStock" column
        builder.Property(p => p.QuantityInStock)
               .HasColumnName("QuantityInStock")
               .HasDefaultValue(0); // Default value of 0 for QuantityInStock

        // Map the CategoryID property to the "CategoryID" column
        builder.Property(p => p.CategoryID)
               .HasColumnName("CategoryID");
    }
}
