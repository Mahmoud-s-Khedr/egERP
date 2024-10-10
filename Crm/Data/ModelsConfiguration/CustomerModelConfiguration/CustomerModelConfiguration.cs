using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

public class CustomerModelConfiguration:IEntityTypeConfiguration<Customer>{


    public void Configure(EntityTypeBuilder<Customer> builder)
    {
        builder.HasKey(e=>e.Id);
        builder.ToTable("customer");
        builder.Property(e=>e.Id).HasColumnName("id");
        builder.Property(e=>e.FirstName).HasColumnName("first_name");
        builder.Property(e=>e.LastName).HasColumnName("last_name");
        builder.Property(e=>e.Email).HasColumnName("email");
    }
}