using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Backend.Models;
public class EmployeeContractConfiguration : IEntityTypeConfiguration<EmployeeContract>
{
    public void Configure(EntityTypeBuilder<EmployeeContract> builder)
    {
        // Set primary key
        builder.HasKey(x => x.ContractID);
        // Map the table name to "EmployeeContracts"
        builder.ToTable("EmployeeContracts");

        // Map the ContractID property to the "ContractID" column
        builder.Property(ec => ec.ContractID)
               .HasColumnName("ContractID") // Column name in the table
               .ValueGeneratedOnAdd(); // Auto-incremented (Identity column)

        // Map the EmployeeID property to the "EmployeeID" column
        builder.Property(ec => ec.EmployeeID)
               .HasColumnName("EmployeeID")
               .IsRequired(); // EmployeeID is required (NOT NULL)

        // Map the ContractStartDate property to the "ContractStartDate" column
        builder.Property(ec => ec.ContractStartDate)
               .HasColumnName("ContractStartDate")
               .IsRequired(); // ContractStartDate is required (NOT NULL)

        // Map the ContractEndDate property to the "ContractEndDate" column
        builder.Property(ec => ec.ContractEndDate)
               .HasColumnName("ContractEndDate")
               .IsRequired(); // ContractEndDate is required (NOT NULL)

        // Map the ContractType property to the "ContractType" column
        builder.Property(ec => ec.ContractType)
               .HasColumnName("ContractType")
               .HasDefaultValue(ContractType.FullTime); // Default value is 'Full Time'

        // Map the ContractDescription property to the "ContractDescription" column
        builder.Property(ec => ec.ContractDescription)
               .HasColumnName("ContractDescription");

        // Map the EmployeeContractStatus property to the "EmployeeContractStatus" column
        builder.Property(ec => ec.ContractStatus)
               .HasColumnName("EmployeeContractStatus")
               .HasDefaultValue(EmployeeContractStatus.Active); // Default value is 'Active'

    }
}
