

using System.Security.Cryptography.X509Certificates;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

public class LogInModelConfiguration:IEntityTypeConfiguration<LogInModel>
{
    public void Configure(EntityTypeBuilder<LogInModel> builder)
    {
        builder.HasKey(e=>e.UserName);
        builder.ToTable("user_login");
        builder.Property(e=>e.UserName).HasColumnName("username");
        builder.Property(e=>e.Password).HasColumnName("password");
        builder.Property(e=>e.EmployeeId).HasColumnName("employee_id");
    
    }
}