using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Backend.Models;
public class SkillConfiguration : IEntityTypeConfiguration<Skill>
{
    public void Configure(EntityTypeBuilder<Skill> builder)
    {
        // primary key
        builder.HasKey(x => x.SkillID);
        // Map the table name to "Skills"
        builder.ToTable("Skills");

        // Map the SkillID property to the "SkillID" column
        builder.Property(s => s.SkillID)
               .HasColumnName("SkillID") // Column name in the table
               .ValueGeneratedOnAdd(); // Auto-incremented (Identity column)

        // Map the SkillName property to the "SkillName" column
        builder.Property(s => s.SkillName)
               .HasColumnName("SkillName")
               .IsRequired() // SkillName is required (NOT NULL)
               .HasMaxLength(100); // Maximum length of 100 characters
    }
}
