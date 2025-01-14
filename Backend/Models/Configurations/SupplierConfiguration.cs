using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Backend.Models;
public class SupplierConfiguration : IEntityTypeConfiguration<Supplier>
{
    public void Configure(EntityTypeBuilder<Supplier> builder)
    {
        // Set the primary key
        builder.HasKey(s => s.SupplierID);
        // Map the table name to "Suppliers"
        builder.ToTable("Suppliers");

        // Map the SupplierID property to the "SupplierID" column
        builder.Property(s => s.SupplierID)
               .HasColumnName("SupplierID")
               .ValueGeneratedOnAdd(); // Auto-incremented (Identity column)

        // Map the SupplierName property to the "SupplierName" column
        builder.Property(s => s.SupplierName)
               .HasColumnName("SupplierName")
               .HasMaxLength(100) // Maximum length for SupplierName
               .IsRequired(); // SupplierName is required (NOT NULL)
    }
}
