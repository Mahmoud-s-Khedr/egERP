using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Backend.Models;
public class UserRoleConfiguration : IEntityTypeConfiguration<UserRole>
{
    public void Configure(EntityTypeBuilder<UserRole> builder)
    {
        // Set the primary key
        builder.HasKey(x => x.UserRoleID);
        // Map the table name to "UserRoles"
        builder.ToTable("UserRoles");

        // Map the UserRoleID property to the "UserRoleID" column
        builder.Property(ur => ur.UserRoleID)
               .HasColumnName("UserRoleID") // Column name in the table
               .ValueGeneratedOnAdd(); // Auto-incremented (Identity column)

        // Map the UserID property to the "UserID" column
        builder.Property(ur => ur.UserID)
               .HasColumnName("UserID")
               .IsRequired(); // UserID is required (NOT NULL)

        // Map the RoleID property to the "RoleID" column
        builder.Property(ur => ur.RoleID)
               .HasColumnName("RoleID")
               .IsRequired(); // RoleID is required (NOT NULL)
    }
}
