
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

public class CustomerContactModelConfiguration : IEntityTypeConfiguration<CustomerContact>
{
    public void Configure(EntityTypeBuilder<CustomerContact> builder)
    {
        builder.HasKey(e=>e.Id);
        builder.ToTable("customer_contact");
        builder.Property(e=>e.Id).HasColumnName("id");
        builder.Property(e=>e.Contact).HasColumnName("contact");
        builder.Property(e=>e.CustomerId).HasColumnName("customer_id");
    }
}