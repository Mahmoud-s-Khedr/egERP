using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Backend.Models;
public class EmployeeAttendanceConfiguration : IEntityTypeConfiguration<EmployeeAttendance>
{
    public void Configure(EntityTypeBuilder<EmployeeAttendance> builder)
    {
        // set primary key
        builder.HasKey(x => x.AttendanceID);
        // Map the table name to "EmployeeAttendances"
        builder.ToTable("EmployeeAttendances");

        // Map the AttendanceID property to the "AttendanceID" column
        builder.Property(ea => ea.AttendanceID)
               .HasColumnName("AttendanceID") // Column name in the table
               .ValueGeneratedOnAdd(); // Auto-incremented (Identity column)

        // Map the EmployeeID property to the "EmployeeID" column
        builder.Property(ea => ea.EmployeeID)
               .HasColumnName("EmployeeID")
               .IsRequired(); // EmployeeID is required (NOT NULL)

        // Map the AttendanceDate property to the "AttendanceDate" column
        builder.Property(ea => ea.AttendanceDate)
               .HasColumnName("AttendanceDate")
               .IsRequired(); // AttendanceDate is required (NOT NULL)

        // Map the CheckInTime property to the "CheckInTime" column
        builder.Property(ea => ea.CheckInTime)
               .HasColumnName("CheckInTime")
               .HasColumnType("TIME"); // Check-in time as TIME data type (nullable)

        // Map the CheckOutTime property to the "CheckOutTime" column
        builder.Property(ea => ea.CheckOutTime)
               .HasColumnName("CheckOutTime")
               .HasColumnType("TIME"); // Check-out time as TIME data type (nullable)

        // Map the EmployeeAttendanceStatus property to the "EmployeeAttendanceStatus" column
        builder.Property(ea => ea.EmployeeAttendanceStatus)
               .HasColumnName("EmployeeAttendanceStatus")
               .HasDefaultValue(AttendanceStatus.Present); // Default value is 'Present'
    
    }
}
