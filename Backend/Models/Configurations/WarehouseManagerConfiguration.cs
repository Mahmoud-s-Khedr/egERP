using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Backend.Models;
public class WarehouseManagerConfiguration : IEntityTypeConfiguration<WarehouseManager>
{
    public void Configure(EntityTypeBuilder<WarehouseManager> builder)
    {
        builder.ToTable("WarehouseManagers");

        builder.HasKey(wm => wm.WarehouseManagerID);

        builder.Property(wm => wm.WarehouseManagerID)
               .ValueGeneratedOnAdd();

        builder.Property(wm => wm.WarehouseID)
               .IsRequired();

        builder.Property(wm => wm.EmployeeID)
               .IsRequired();
    }
}
