using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Backend.Models;
public class WarehouseConfiguration : IEntityTypeConfiguration<Warehouse>
{
    public void Configure(EntityTypeBuilder<Warehouse> builder)
    {
        //Set primary key
        builder.HasKey(x => x.WarehouseID);
        // Map the table name to "Warehouses"
        builder.ToTable("Warehouses");

        // Map the WarehouseID property to the "WarehouseID" column
        builder.Property(w => w.WarehouseID)
               .HasColumnName("WarehouseID") // Column name in the table
               .ValueGeneratedOnAdd(); // Auto-incremented (Identity column)

        // Map the WarehouseName property to the "WarehouseName" column
        builder.Property(w => w.WarehouseName)
               .HasColumnName("WarehouseName")
               .IsRequired() // WarehouseName is required (NOT NULL)
               .HasMaxLength(100); // Max length of 100 characters

        builder.Property(w => w.IsActive)
               .HasColumnName("IsActive")
               .HasDefaultValue(true); // Default value TRUE for IsActive
        // Optionally, you can configure additional properties if needed
    }
}
