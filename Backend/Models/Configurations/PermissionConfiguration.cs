using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Backend.Models;
public class PermissionConfiguration : IEntityTypeConfiguration<Permission>
{
    public void Configure(EntityTypeBuilder<Permission> builder)
    {
        // Set the primary key
        builder.HasKey(x => x.PermissionID);
        // Map the table name to "Permissions"
        builder.ToTable("Permissions");

        // Map the PermissionID property to the "PermissionID" column
        builder.Property(p => p.PermissionID)
               .HasColumnName("PermissionID") // Column name in the table
               .ValueGeneratedOnAdd(); // Auto-incremented (Identity column)

       // Map the PermissionName property to the "PermissionName" column
       builder.Property(p => p.PermissionName)
              .HasColumnName("PermissionName")
              .IsRequired() // PermissionName is required (NOT NULL)
              .HasMaxLength(100); // Maximum length of 100 characters

        // Map the PermissionDescription property to the "PermissionDescription" column
        builder.Property(p => p.PermissionDescription)
               .HasColumnName("PermissionDescription")
               .HasColumnType("TEXT"); // Description as a text column type
    }
}
