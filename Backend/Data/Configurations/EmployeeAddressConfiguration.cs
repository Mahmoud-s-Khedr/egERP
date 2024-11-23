using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Backend.Models;
public class EmployeeAddressConfiguration : IEntityTypeConfiguration<EmployeeAddress>
{
    public void Configure(EntityTypeBuilder<EmployeeAddress> builder)
    {
        // Set the primary key
        builder.HasKey(x => x.AddressID);
        // Map the table name to "EmployeeAddresses"
        builder.ToTable("EmployeeAddresses");

        // Map the AddressID property to the "AddressID" column
        builder.Property(ea => ea.AddressID)
               .HasColumnName("AddressID") // Column name in the table
               .ValueGeneratedOnAdd(); // Auto-incremented (Identity column)

        // Map the EmployeeID property to the "EmployeeID" column
        builder.Property(ea => ea.EmployeeID)
               .HasColumnName("EmployeeID")
               .IsRequired(); // EmployeeID is required (NOT NULL)

        // Map the AddressLine1 property to the "AddressLine1" column
        builder.Property(ea => ea.AddressLine1)
               .HasColumnName("AddressLine1")
               .IsRequired() // AddressLine1 is required (NOT NULL)
               .HasMaxLength(100); // Maximum length of 100 characters

        // Map the AddressLine2 property to the "AddressLine2" column
        builder.Property(ea => ea.AddressLine2)
               .HasColumnName("AddressLine2")
               .HasMaxLength(100); // Maximum length of 100 characters (optional field)

        // Map the City property to the "City" column
        builder.Property(ea => ea.City)
               .HasColumnName("City")
               .IsRequired() // City is required (NOT NULL)
               .HasMaxLength(50); // Maximum length of 50 characters

        // Map the Province property to the "Province" column
        builder.Property(ea => ea.Province)
               .HasColumnName("Province")
               .IsRequired() // Province is required (NOT NULL)
               .HasMaxLength(50); // Maximum length of 50 characters

        // Map the Country property to the "Country" column
        builder.Property(ea => ea.Country)
               .HasColumnName("Country")
               .IsRequired() // Country is required (NOT NULL)
               .HasMaxLength(50); // Maximum length of 50 characters

    }
}
