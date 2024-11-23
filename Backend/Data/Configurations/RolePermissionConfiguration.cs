using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Backend.Models;
public class RolePermissionConfiguration : IEntityTypeConfiguration<RolePermission>
{
    public void Configure(EntityTypeBuilder<RolePermission> builder)
    {
        // Set the primary key
        builder.HasKey(x => x.RolePermissionID);
        // Map the table name to "RolePermissions"
        builder.ToTable("RolePermissions");

        // Map the RolePermissionID property to the "RolePermissionID" column
        builder.Property(rp => rp.RolePermissionID)
               .HasColumnName("RolePermissionID") // Column name in the table
               .ValueGeneratedOnAdd(); // Auto-incremented (Identity column)

        // Map the RoleID property to the "RoleID" column
        builder.Property(rp => rp.RoleID)
               .HasColumnName("RoleID")
               .IsRequired(); // RoleID is required (NOT NULL)

        // Map the PermissionID property to the "PermissionID" column
        builder.Property(rp => rp.PermissionID)
               .HasColumnName("PermissionID")
               .IsRequired(); // PermissionID is required (NOT NULL)

    }
}
