using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Backend.Models;
public class EmployeeDepartmentTransferConfiguration : IEntityTypeConfiguration<EmployeeDepartmentTransfer>
{
    public void Configure(EntityTypeBuilder<EmployeeDepartmentTransfer> builder)
    {
        // Set the primary key
        builder.HasKey(x => x.TransferID);
        // Map the table name to "EmployeeDepartmentTransfers"
        builder.ToTable("EmployeeDepartmentTransfers");

        // Map the TransferID property to the "TransferID" column
        builder.Property(edt => edt.TransferID)
               .HasColumnName("TransferID") // Column name in the table
               .ValueGeneratedOnAdd(); // Auto-incremented (Identity column)

        // Map the EmployeeID property to the "EmployeeID" column
        builder.Property(edt => edt.EmployeeID)
               .HasColumnName("EmployeeID")
               .IsRequired(); // EmployeeID is required (NOT NULL)

        // Map the TransferDate property to the "TransferDate" column
        builder.Property(edt => edt.TransferDate)
               .HasColumnName("TransferDate")
               .IsRequired(); // TransferDate is required (NOT NULL)

        // Map the NewDepartmentID property to the "NewDepartmentID" column
        builder.Property(edt => edt.NewDepartmentID)
               .HasColumnName("NewDepartmentID")
               .IsRequired(); // NewDepartmentID is required (NOT NULL)

        // Map the Reason property to the "Reason" column
        builder.Property(edt => edt.Reason)
               .HasColumnName("Reason");

        // Map the EmployeeDepartmentTransferStatus property to the "EmployeeDepartmentTransferStatus" column
        builder.Property(edt => edt.TransferStatus)
               .HasColumnName("EmployeeDepartmentTransferStatus"); // Default value is 'Pending'

        // Map the OldDepartmentID property to the "OldDepartmentID" column
        builder.Property(edt => edt.OldDepartmentID)
               .HasColumnName("OldDepartmentID");

    }
}
