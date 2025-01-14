using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Backend.Models;
public class RoleConfiguration : IEntityTypeConfiguration<Role>
{
    public void Configure(EntityTypeBuilder<Role> builder)
    {
        // Set the primary key
        builder.HasKey(x => x.RoleID);
        // Map the table name to "Roles"
        builder.ToTable("Roles");

        // Map the RoleID property to the "RoleID" column
        builder.Property(r => r.RoleID)
               .HasColumnName("RoleID") // Column name in the table
               .ValueGeneratedOnAdd(); // Auto-incremented (Identity column)

              // Map the RoleName property to the "RoleName" column
       builder.Property(r => r.RoleName)
              .HasColumnName("RoleName")
              .IsRequired() // RoleName is required (NOT NULL)
              .HasMaxLength(50); // Maximum length of 50 characters

        // Map the Description property to the "Description" column
        builder.Property(r => r.Description)
               .HasColumnName("Description")
               .HasColumnType("TEXT"); // Description as a text column type
    }
}
