using Library.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Library.Infrastructure.Persistence.Configurations
{
    public class AuthorConfigurations : IEntityTypeConfiguration<Author>
    {
        public void Configure(EntityTypeBuilder<Author> builder)
        {
            // PRIMARY KEY
            builder.HasKey(author => author.Id);

            // PROPERTIES
            builder.Property(author => author.Name)
                .IsRequired()
                .HasMaxLength(60);

            builder.Property(author => author.LastName)
                .IsRequired()
                .HasMaxLength(60);

            builder.Property(author => author.DateofBirth)
                .IsRequired();

            // TABLE NAME
            builder.ToTable("Authors");
        }
    }
}