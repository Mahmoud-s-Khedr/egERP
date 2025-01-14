using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Backend.Models;
public class LeaveTypeConfiguration : IEntityTypeConfiguration<LeaveType>
{
    public void Configure(EntityTypeBuilder<LeaveType> builder)
    {
        // set primary key
        builder.HasKey(x => x.LeaveTypeID);
        // Map the table name to "LeaveTypes"
        builder.ToTable("LeaveTypes");

        // Map the LeaveTypeID property to the "LeaveTypeID" column
        builder.Property(lt => lt.LeaveTypeID)
               .HasColumnName("LeaveTypeID") // Column name in the table
               .ValueGeneratedOnAdd(); // Auto-incremented (Identity column)

        // Map the LeaveTypeName property to the "LeaveTypeName" column
        builder.Property(lt => lt.LeaveTypeName)
               .HasColumnName("LeaveTypeName")
               .IsRequired() // LeaveTypeName is required (NOT NULL)
               .HasMaxLength(50); // Maximum length of 50 characters

        // Map the LeaveTypeDescription property to the "LeaveTypeDescription" column
        builder.Property(lt => lt.LeaveTypeDescription)
               .HasColumnName("LeaveTypeDescription")
               .HasColumnType("TEXT"); // Description can be of type TEXT

    }
}
