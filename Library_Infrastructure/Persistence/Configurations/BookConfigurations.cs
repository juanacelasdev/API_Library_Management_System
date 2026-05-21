using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Library.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Library.Infrastructure.Persistence.Configurations
{
    public class BookConfigurations : IEntityTypeConfiguration<Book>
    {
        public void Configure(EntityTypeBuilder<Book> builder)
        {
            
            builder.HasKey(book => book.Id);

            builder.Property(book => book.Title)
                .IsRequired()
                .HasMaxLength(150);

            builder.Property(book => book.ISBN)
                .IsRequired()
                .HasMaxLength(50);

            builder.Property(book => book.YearofPublication)
                .IsRequired();

            builder.Property(book => book.Price)
                .HasColumnType("decimal(10,2)");

            // UNIQUE ISBN
            builder.HasIndex(book => book.ISBN)
                .IsUnique();

            // RELATIONSHIP WITH CATEGORY
            builder.HasOne(book => book.Category)
                .WithMany(category => category.Books)
                .HasForeignKey(book => book.CategoryId)
                .OnDelete(DeleteBehavior.Restrict);

            
            builder.ToTable("Books");
        }
    }
}
