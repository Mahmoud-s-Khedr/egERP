using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Backend.Models;
public class ProductCategoryConfiguration : IEntityTypeConfiguration<ProductCategory>
{
    public void Configure(EntityTypeBuilder<ProductCategory> builder)
    {
        //Set primary key
        builder.HasKey(x => x.CategoryID);
        // Map the table name to "ProductCategories"
        builder.ToTable("ProductCategories");

        // Map the CategoryID property to the "CategoryID" column
        builder.Property(pc => pc.CategoryID)
               .HasColumnName("CategoryID") // Column name in the table
               .ValueGeneratedOnAdd(); // Auto-incremented (Identity column)

        // Map the CategoryName property to the "CategoryName" column
        builder.Property(pc => pc.CategoryName)
               .HasColumnName("CategoryName")
               .IsRequired() // CategoryName is required (NOT NULL)
               .HasMaxLength(100); // Max length of 100 characters

        // Map the ProductCategoryDescription property to the "ProductCategoryDescription" column
        builder.Property(pc => pc.ProductCategoryDescription)
               .HasColumnName("ProductCategoryDescription")
               .HasColumnType("TEXT"); // TEXT type for description
    }
}
