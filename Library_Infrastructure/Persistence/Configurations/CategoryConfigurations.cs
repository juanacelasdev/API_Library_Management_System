using Library.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Library.Infrastructure.Persistence.Configurations
{
    public class CategoryConfigurations : IEntityTypeConfiguration<Category>
    {
        public void Configure(EntityTypeBuilder<Category> builder)
        {
            // PRIMARY KEY
            builder.HasKey(category => category.Id);

            // PROPERTIES
            builder.Property(category => category.Name)
                .IsRequired()
                .HasMaxLength(60);

            builder.Property(category => category.Description)
                .IsRequired()
                .HasMaxLength(255);

            builder.Property(category => category.IsActive)
                .IsRequired();

            // TABLE NAME
            builder.ToTable("Categories");
        }
    }
}