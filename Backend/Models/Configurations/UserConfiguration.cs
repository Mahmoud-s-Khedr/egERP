using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Backend.Models;
public class UserConfiguration : IEntityTypeConfiguration<User>
{
    public void Configure(EntityTypeBuilder<User> builder)
    {
        builder.HasKey(x => x.UserID);
        // Map the table name to "Users"
        builder.ToTable("Users");

        // Map the UserID property to the "UserID" column
        builder.Property(u => u.UserID)
               .HasColumnName("UserID") // Column name in the table
               .ValueGeneratedOnAdd(); // Auto-incremented (Identity column)

        // Map the PasswordHash property to the "PasswordHash" column
        builder.Property(u => u.PasswordHash)
               .HasColumnName("PasswordHash")
               .IsRequired() // PasswordHash is required (NOT NULL)
               .HasMaxLength(255); // Maximum length of 255 characters

        // Map the Email property to the "Email" column
        builder.Property(u => u.Email)
               .HasColumnName("Email")
               .IsRequired() // Email is required (NOT NULL)
               .HasMaxLength(100); // maximum length of 100 characters

        // Map the IsActive property to the "IsActive" column
        builder.Property(u => u.IsActive)
               .HasColumnName("IsActive")
               .HasDefaultValue(true); // Default value TRUE for IsActive

        // Map the CreatedAt property to the "CreatedAt" column
        builder.Property(u => u.CreatedAt)
               .HasColumnName("CreatedAt")
               .HasDefaultValueSql("CURRENT_TIMESTAMP"); // Default value for CreatedAt

        // Map the EmployeeID property to the "EmployeeID" column
        builder.Property(u => u.EmployeeID)
               .HasColumnName("EmployeeID");

    }
}
