

using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

public class CustomerInternalNoteModelConfiguration:IEntityTypeConfiguration<CustomerInternalNote>{
    public void Configure(EntityTypeBuilder<CustomerInternalNote> builder){
        builder.ToTable("customer_internal_note");
        builder.HasKey(e=>e.Id);
        builder.Property(e=>e.Id).HasColumnName("id");
        builder.Property(e=>e.CustomerId).HasColumnName("customer_id");
        builder.Property(e=>e.EmployeeId).HasColumnName("employee_id");
        builder.Property(e=>e.Note).HasColumnName("note");
        builder.Property(e=>e.Date).HasColumnName("date");
    }
}