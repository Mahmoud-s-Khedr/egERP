using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Backend.Models;
public class WarehouseLocationConfiguration : IEntityTypeConfiguration<WarehouseLocation>
{
    public void Configure(EntityTypeBuilder<WarehouseLocation> builder)
    {
        //Set primary key
        builder.HasKey(x => x.LocationID);
        // Map the table name to "WarehouseLocations"
        builder.ToTable("WarehouseLocations");

        // Map the LocationID property to the "LocationID" column
        builder.Property(wl => wl.LocationID)
               .HasColumnName("LocationID") // Column name in the table
               .ValueGeneratedOnAdd(); // Auto-incremented (Identity column)

        // Map the WarehouseID property to the "WarehouseID" column
        builder.Property(wl => wl.WarehouseID)
               .HasColumnName("WarehouseID")
               .IsRequired(); // WarehouseID is required (NOT NULL)

        // Map the LocationName property to the "LocationName" column
        builder.Property(wl => wl.LocationName)
               .HasColumnName("LocationName")
               .IsRequired() // LocationName is required (NOT NULL)
               .HasMaxLength(100); // Max length of 100 characters

        // Map the AddressLine1 property to the "AddressLine1" column
        builder.Property(wl => wl.AddressLine1)
               .HasColumnName("AddressLine1")
               .IsRequired() // AddressLine1 is required (NOT NULL)
               .HasMaxLength(100); // Max length of 100 characters

        // Map the AddressLine2 property to the "AddressLine2" column
        builder.Property(wl => wl.AddressLine2)
               .HasColumnName("AddressLine2")
               .HasMaxLength(100); // Max length of 100 characters

        // Map the City property to the "City" column
        builder.Property(wl => wl.City)
               .HasColumnName("City")
               .IsRequired() // City is required (NOT NULL)
               .HasMaxLength(50); // Max length of 50 characters

        // Map the Province property to the "Province" column
        builder.Property(wl => wl.Province)
               .HasColumnName("Province")
               .IsRequired() // Province is required (NOT NULL)
               .HasMaxLength(50); // Max length of 50 characters

        // Map the Country property to the "Country" column
        builder.Property(wl => wl.Country)
               .HasColumnName("Country")
               .IsRequired() // Country is required (NOT NULL)
               .HasMaxLength(50); // Max length of 50 characters

        // Map the PostalCode property to the "PostalCode" column
        builder.Property(wl => wl.PostalCode)
               .HasColumnName("PostalCode")
               .IsRequired() // PostalCode is required (NOT NULL)
               .HasMaxLength(10); // Max length of 10 characters

    }
}
