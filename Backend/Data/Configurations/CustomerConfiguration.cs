using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Backend.Models;
public class CustomerConfiguration : IEntityTypeConfiguration<Customer>
{
    public void Configure(EntityTypeBuilder<Customer> builder)
    {
        // Set the primary key
        builder.HasKey(x => x.CustomerID);
        // Map the table name to "Customers"
        builder.ToTable("Customers");

        // Map the CustomerID property to the "CustomerID" column
        builder.Property(c => c.CustomerID)
               .HasColumnName("CustomerID") // Column name in the table
               .ValueGeneratedOnAdd(); // Auto-incremented (Identity column)

        // Map the CustomerName property to the "CustomerName" column
        builder.Property(c => c.CustomerName)
               .HasColumnName("CustomerName")
               .IsRequired() // CustomerName is required (NOT NULL)
               .HasMaxLength(100); // Max length of 100 characters
    }
}
