using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Backend.Models;
public class EmployeeContactConfiguration : IEntityTypeConfiguration<EmployeeContact>
{
    public void Configure(EntityTypeBuilder<EmployeeContact> builder)
    {
        // Set the primary key
        builder.HasKey(x => x.ContactID);
        // Map the table name to "EmployeeContacts"
        builder.ToTable("EmployeeContacts");

        // Map the ContactID property to the "ContactID" column
        builder.Property(ec => ec.ContactID)
               .HasColumnName("ContactID") // Column name in the table
               .ValueGeneratedOnAdd(); // Auto-incremented (Identity column)

        // Map the EmployeeID property to the "EmployeeID" column
        builder.Property(ec => ec.EmployeeID)
               .HasColumnName("EmployeeID")
               .IsRequired(); // EmployeeID is required (NOT NULL)

        // Map the ContactType property to the "ContactType" column
        builder.Property(ec => ec.ContactType)
               .HasColumnName("ContactType")
               .IsRequired(); // ContactType is required (NOT NULL)

        // Map the ContactInfo property to the "ContactInfo" column
        builder.Property(ec => ec.ContactInfo)
               .HasColumnName("ContactInfo")
               .IsRequired() // ContactInfo is required (NOT NULL)
               .HasMaxLength(100); // Maximum length of 100 characters

    }
}
