using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Backend.Models;
public class EmployeeSkillConfiguration : IEntityTypeConfiguration<EmployeeSkill>
{
    public void Configure(EntityTypeBuilder<EmployeeSkill> builder)
    {
        // Set the primary key
        builder.HasKey(es => es.EmployeeSkillID);
        // Map the table name to "EmployeeSkills"
        builder.ToTable("EmployeeSkills");

        // Map the EmployeeSkillID property to the "EmployeeSkillID" column
        builder.Property(es => es.EmployeeSkillID)
               .HasColumnName("EmployeeSkillID") // Column name in the table
               .ValueGeneratedOnAdd(); // Auto-incremented (Identity column)

        // Map the EmployeeID property to the "EmployeeID" column
        builder.Property(es => es.EmployeeID)
               .HasColumnName("EmployeeID")
               .IsRequired(); // EmployeeID is required (NOT NULL)

        // Map the SkillID property to the "SkillID" column
        builder.Property(es => es.SkillID)
               .HasColumnName("SkillID")
               .IsRequired(); // SkillID is required (NOT NULL)

        // Map the ProficiencyLevel property to the "ProficiencyLevel" column
        builder.Property(es => es.ProficiencyLevel)
               .HasColumnName("ProficiencyLevel")
               .IsRequired(); // ProficiencyLevel is required (NOT NULL)

    }
}
