using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Backend.Models;
public class DepartmentManagerConfiguration : IEntityTypeConfiguration<DepartmentManager>
{
    public void Configure(EntityTypeBuilder<DepartmentManager> builder)
    {
        // Configure the composite primary key (ManagerID, DepartmentID)
        builder.HasKey(dm => new { dm.ManagerID, dm.DepartmentID });
        // Map the table name to "DepartmentManagers"
        builder.ToTable("DepartmentManagers");

        // Map the ManagerID property to the "ManagerID" column
        builder.Property(dm => dm.ManagerID)
               .HasColumnName("ManagerID")
               .IsRequired(); // ManagerID is required (NOT NULL)

        // Map the DepartmentID property to the "DepartmentID" column
        builder.Property(dm => dm.DepartmentID)
               .HasColumnName("DepartmentID")
               .IsRequired(); // DepartmentID is required (NOT NULL)

        // Map the IsActive property to the "IsActive" column
        builder.Property(dm => dm.IsActive)
               .HasColumnName("IsActive")
               .HasDefaultValue(true); // Default value TRUE for IsActive


    }
}
