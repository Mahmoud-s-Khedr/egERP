using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

public class CustomerModelConfiguration:IEntityTypeConfiguration<Customer>{

    public void Configure(EntityTypeBuilder<Customer> builder){
        builder.ToTable("customer");
        builder.HasKey(e=>e.Id);
        builder.Property(e=>e.Id).HasColumnName("id");
        builder.Property(e=>e.FirstName).HasColumnName("first_name");
        builder.Property(e=>e.LastName).HasColumnName("last_name");
        builder.Property(e=>e.Email).HasColumnName("email");
        builder.HasMany(e=>e.CustomerAddresses).WithOne(address=>address.Customer).HasForeignKey(address=>address.CustomerId);
        builder.HasMany(e=>e.CustomerContacts).WithOne(contact=>contact.Customer).HasForeignKey(contact=>contact.CustomerId);
    }
}

