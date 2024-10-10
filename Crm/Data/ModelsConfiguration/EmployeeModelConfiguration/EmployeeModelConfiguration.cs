

using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

public class EmployeeModelConfiguration : IEntityTypeConfiguration<Employee>{

    public void Configure(EntityTypeBuilder<Employee> builder){
        builder.HasKey("Id");
        builder.ToTable("employee");
        builder.Property(e=>e.Id).HasColumnName("id");
        builder.Property(e=>e.FirstName).HasColumnName("first_name");
        builder.Property(e=>e.LastName).HasColumnName("last_name");
        builder.Property(e=>e.Email).HasColumnName("email");
        builder.Property(e=>e.Department).HasColumnName("department");
        builder.Property(e=>e.Authority).HasColumnName("authority");
        
    }

}