using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Backend.Models;
public class SupplierAddressConfiguration : IEntityTypeConfiguration<SupplierAddress>
{
    public void Configure(EntityTypeBuilder<SupplierAddress> builder)
    {
        // Set primary key
        builder.HasKey(sa => sa.AddressID);
        // Map the table name to "SupplierAddresses"
        builder.ToTable("SupplierAddresses");

        // Map the AddressID property to the "AddressID" column
        builder.Property(sa => sa.AddressID)
               .HasColumnName("AddressID")
               .ValueGeneratedOnAdd(); // Auto-incremented (Identity column)

        // Map the SupplierID property to the "SupplierID" column
        builder.Property(sa => sa.SupplierID)
               .HasColumnName("SupplierID")
               .IsRequired(); // SupplierID is required (NOT NULL)

        // Map the AddressLine1 property to the "AddressLine1" column
        builder.Property(sa => sa.AddressLine1)
               .HasColumnName("AddressLine1")
               .HasMaxLength(255)
               .IsRequired(); // AddressLine1 is required (NOT NULL)

        // Map the AddressLine2 property to the "AddressLine2" column
        builder.Property(sa => sa.AddressLine2)
               .HasColumnName("AddressLine2")
               .HasMaxLength(255); // Nullable field

        // Map the City property to the "City" column
        builder.Property(sa => sa.City)
               .HasColumnName("City")
               .HasMaxLength(100)
               .IsRequired(); // City is required (NOT NULL)

        // Map the Province property to the "Province" column
        builder.Property(sa => sa.Province)
               .HasColumnName("Province")
               .HasMaxLength(50)
               .IsRequired(); // Province is required (NOT NULL)

        // Map the PostalCode property to the "PostalCode" column
        builder.Property(sa => sa.PostalCode)
               .HasColumnName("PostalCode")
               .HasMaxLength(20)
               .IsRequired(); // PostalCode is required (NOT NULL)

        // Map the Country property to the "Country" column
        builder.Property(sa => sa.Country)
               .HasColumnName("Country")
               .HasMaxLength(100)
               .IsRequired(); // Country is required (NOT NULL)

    }
}
