using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Backend.Models;
public class InvoiceConfiguration : IEntityTypeConfiguration<Invoice>
{
    public void Configure(EntityTypeBuilder<Invoice> builder)
    {
        // Set the primary key
        builder.HasKey(i => i.InvoiceID);
        // Map the table name to "Invoices"
        builder.ToTable("Invoices");

        // Map the InvoiceID property to the "InvoiceID" column
        builder.Property(i => i.InvoiceID)
               .HasColumnName("InvoiceID") // Column name in the table
               .ValueGeneratedOnAdd(); // Auto-incremented (Identity column)

        // Map the OrderID property to the "OrderID" column
        builder.Property(i => i.OrderID)
               .HasColumnName("OrderID")
               .IsRequired(); // OrderID is required (NOT NULL)

        // Map the InvoiceDate property to the "InvoiceDate" column
        builder.Property(i => i.InvoiceDate)
               .HasColumnName("InvoiceDate")
               .HasDefaultValueSql("CURRENT_TIMESTAMP"); // Default value for InvoiceDate

        // Map the DueDate property to the "DueDate" column
        builder.Property(i => i.DueDate)
               .HasColumnName("DueDate")
               .IsRequired(false); // Nullable

        // Map the TotalAmount property to the "TotalAmount" column
        builder.Property(i => i.TotalAmount)
               .HasColumnName("TotalAmount")
               .HasColumnType("DECIMAL(10, 2)"); // Set column type for TotalAmount

        // Map the PaidAmount property to the "PaidAmount" column
        builder.Property(i => i.PaidAmount)
               .HasColumnName("PaidAmount")
               .HasColumnType("DECIMAL(10, 2)")
               .HasDefaultValue(0); // Default value for PaidAmount
    }
}
