using Library.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Library.Infrastructure.Persistence.Configurations
{
    public class BookCopyConfigurations : IEntityTypeConfiguration<BookCopy>
    {
        public void Configure(EntityTypeBuilder<BookCopy> builder)
        {
            
            builder.HasKey(bookcopy => bookcopy.Id);

            
            builder.Property(bookcopy => bookcopy.InventoryCode)
                .IsRequired()
                .HasMaxLength(50);

            builder.Property(bookcopy => bookcopy.Status)
                .IsRequired();

            builder.Property(bookcopy => bookcopy.IsActive)
                .IsRequired();

            
            builder.HasIndex(bookcopy => bookcopy.InventoryCode)
                .IsUnique();

            
            builder.HasOne(bookcopy => bookcopy.Book)
                .WithMany(book => book.BookCopies)
                .HasForeignKey(bookcopy => bookcopy.BookId)
                .OnDelete(DeleteBehavior.Cascade);

            // TABLE NAME
            builder.ToTable("BookCopies");
        }
    }
}