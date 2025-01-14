using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Backend.Models;
public class EmployeeResignationConfiguration : IEntityTypeConfiguration<EmployeeResignation>
{
    public void Configure(EntityTypeBuilder<EmployeeResignation> builder)
    {
        // set primary key
        builder.HasKey(x => x.ResignationID);
        // Map the table name to "EmployeeResignations"
        builder.ToTable("EmployeeResignations");

        // Map the ResignationID property to the "ResignationID" column
        builder.Property(er => er.ResignationID)
               .HasColumnName("ResignationID") // Column name in the table
               .ValueGeneratedOnAdd(); // Auto-incremented (Identity column)

        // Map the EmployeeID property to the "EmployeeID" column
        builder.Property(er => er.EmployeeID)
               .HasColumnName("EmployeeID")
               .IsRequired(); // EmployeeID is required (NOT NULL)

        // Map the ResignationDate property to the "ResignationDate" column
        builder.Property(er => er.ResignationDate)
               .HasColumnName("ResignationDate")
               .IsRequired(); // ResignationDate is required (NOT NULL)

        // Map the Reason property to the "Reason" column
        builder.Property(er => er.Reason)
               .HasColumnName("Reason");

        // Map the EmployeeResignationStatus property to the "EmployeeResignationStatus" column
        builder.Property(er => er.ResignationStatus)
               .HasColumnName("EmployeeResignationStatus")
               .HasDefaultValue(EmployeeResignationStatus.Pending); // Default value is 'Pending'

    }
}
