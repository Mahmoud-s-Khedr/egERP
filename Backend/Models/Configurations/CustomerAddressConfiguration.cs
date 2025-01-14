using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Backend.Models;
public class CustomerAddressConfiguration : IEntityTypeConfiguration<CustomerAddress>
{
    public void Configure(EntityTypeBuilder<CustomerAddress> builder)
    {
        // Set the primary key
        builder.HasKey(x => x.AddressID);
        // Map the table name to "CustomerAddresses"
        builder.ToTable("CustomerAddresses");

        // Map the AddressID property to the "AddressID" column
        builder.Property(ca => ca.AddressID)
               .HasColumnName("AddressID") // Column name in the table
               .ValueGeneratedOnAdd(); // Auto-incremented (Identity column)

        // Map the CustomerID property to the "CustomerID" column
        builder.Property(ca => ca.CustomerID)
               .HasColumnName("CustomerID")
               .IsRequired(); // CustomerID is required (NOT NULL)

        // Map the AddressLine1 property to the "AddressLine1" column
        builder.Property(ca => ca.AddressLine1)
               .HasColumnName("AddressLine1")
               .IsRequired() // AddressLine1 is required (NOT NULL)
               .HasMaxLength(255); // Max length of 255 characters

        // Map the AddressLine2 property to the "AddressLine2" column
        builder.Property(ca => ca.AddressLine2)
               .HasColumnName("AddressLine2")
               .HasMaxLength(255); // Max length of 255 characters

        // Map the City property to the "City" column
        builder.Property(ca => ca.City)
               .HasColumnName("City")
               .IsRequired() // City is required (NOT NULL)
               .HasMaxLength(100); // Max length of 100 characters

        // Map the Province property to the "Province" column
        builder.Property(ca => ca.Province)
               .HasColumnName("Province")
               .IsRequired() // Province is required (NOT NULL)
               .HasMaxLength(50); // Max length of 50 characters

        // Map the PostalCode property to the "PostalCode" column
        builder.Property(ca => ca.PostalCode)
               .HasColumnName("PostalCode")
               .IsRequired() // PostalCode is required (NOT NULL)
               .HasMaxLength(20); // Max length of 20 characters

        // Map the Country property to the "Country" column
        builder.Property(ca => ca.Country)
               .HasColumnName("Country")
               .IsRequired() // Country is required (NOT NULL)
               .HasMaxLength(100); // Max length of 100 characters
    }
}
