using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Backend.Models;
public class SupplierContactConfiguration : IEntityTypeConfiguration<SupplierContact>
{
    public void Configure(EntityTypeBuilder<SupplierContact> builder)
    {
        // Set the primary key
        builder.HasKey(sc => sc.ContactID);
        // Map the table name to "SupplierContacts"
        builder.ToTable("SupplierContacts");

        // Map the ContactID property to the "ContactID" column
        builder.Property(sc => sc.ContactID)
               .HasColumnName("ContactID")
               .ValueGeneratedOnAdd(); // Auto-incremented (Identity column)

        // Map the SupplierID property to the "SupplierID" column
        builder.Property(sc => sc.SupplierID)
               .HasColumnName("SupplierID")
               .IsRequired(); // SupplierID is required (NOT NULL)

        // Map the ContactType property to the "ContactType" column
        builder.Property(sc => sc.ContactType)
               .HasColumnName("ContactType")
               .HasMaxLength(50)
               .IsRequired(); // ContactType is required (NOT NULL)

        // Map the ContactInfo property to the "ContactInfo" column
        builder.Property(sc => sc.ContactInfo)
               .HasColumnName("ContactInfo")
               .HasMaxLength(100)
               .IsRequired(); // ContactInfo is required (NOT NULL)

    }
}
