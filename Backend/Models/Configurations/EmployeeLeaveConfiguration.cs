using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Backend.Models;
public class EmployeeLeaveConfiguration : IEntityTypeConfiguration<EmployeeLeave>
{
    public void Configure(EntityTypeBuilder<EmployeeLeave> builder)
    {
        // Set the primary key
        builder.HasKey(el => el.LeaveID);
        // Map the table name to "EmployeeLeaves"
        builder.ToTable("EmployeeLeaves");

        // Map the LeaveID property to the "LeaveID" column
        builder.Property(el => el.LeaveID)
               .HasColumnName("LeaveID") // Column name in the table
               .ValueGeneratedOnAdd(); // Auto-incremented (Identity column)

        // Map the EmployeeID property to the "EmployeeID" column
        builder.Property(el => el.EmployeeID)
               .HasColumnName("EmployeeID")
               .IsRequired(); // EmployeeID is required (NOT NULL)

        // Map the LeaveTypeID property to the "LeaveTypeID" column
        builder.Property(el => el.LeaveTypeID)
               .HasColumnName("LeaveTypeID")
               .IsRequired(); // LeaveTypeID is required (NOT NULL)

        // Map the StartDate property to the "StartDate" column
        builder.Property(el => el.StartDate)
               .HasColumnName("StartDate")
               .IsRequired(); // StartDate is required (NOT NULL)

        // Map the EndDate property to the "EndDate" column
        builder.Property(el => el.EndDate)
               .HasColumnName("EndDate")
               .IsRequired(); // EndDate is required (NOT NULL)

        // Map the EmployeeLeaveStatus property to the "EmployeeLeaveStatus" column
        builder.Property(el => el.EmployeeLeaveStatus)
               .HasColumnName("EmployeeLeaveStatus")
               .HasDefaultValue(LeaveStatus.Pending); // Default value is 'Pending'
    }
}
