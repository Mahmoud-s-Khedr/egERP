using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

public class CustomerAddressModelConfiguration:IEntityTypeConfiguration<CustomerAddress>
{
    public void Configure(EntityTypeBuilder<CustomerAddress> builder)
    {
        builder.HasKey(e=>e.Id);
        builder.ToTable("customer_address");
        builder.Property(e=> e.Id).HasColumnName("id"); 
        builder.Property(e=>e.Address).HasColumnName("address");
        builder.Property(e=>e.City).HasColumnName("city");
        builder.Property(e=>e.Country).HasColumnName("country");
        builder.Property(e=>e.State).HasColumnName("state");
        builder.Property(e=>e.ZipCode).HasColumnName("zip_code");
        builder.Property(e=>e.CustomerId).HasColumnName("customer_id");
        builder.Property(e=>e.Availablity).HasColumnName("availability").HasConversion<string>();
    }
}