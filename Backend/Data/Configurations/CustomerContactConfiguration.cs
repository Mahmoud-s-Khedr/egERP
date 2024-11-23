using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Backend.Models;
public class CustomerContactConfiguration : IEntityTypeConfiguration<CustomerContact>
{
    public void Configure(EntityTypeBuilder<CustomerContact> builder)
    {
       // Set the primary key
        builder.HasKey(x => x.ContactID);
        // Map the table name to "CustomerContacts"
        builder.ToTable("CustomerContacts");

        // Map the ContactID property to the "ContactID" column
        builder.Property(cc => cc.ContactID)
               .HasColumnName("ContactID") // Column name in the table
               .ValueGeneratedOnAdd(); // Auto-incremented (Identity column)

        // Map the CustomerID property to the "CustomerID" column
        builder.Property(cc => cc.CustomerID)
               .HasColumnName("CustomerID")
               .IsRequired(); // CustomerID is required (NOT NULL)

        // Map the ContactType property to the "ContactType" column
        builder.Property(cc => cc.ContactType)
               .HasColumnName("ContactType")
               .IsRequired() // ContactType is required (NOT NULL)
               .HasMaxLength(50); // Max length of 50 characters (for Phone/Email)

        // Map the ContactInfo property to the "ContactInfo" column
        builder.Property(cc => cc.ContactInfo)
               .HasColumnName("ContactInfo")
               .IsRequired() // ContactInfo is required (NOT NULL)
               .HasMaxLength(100); // Max length of 100 characters

    }
}
