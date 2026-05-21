using Library.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Library.Infrastructure.Persistence.Configurations
{
    public class BookAuthorConfigurations : IEntityTypeConfiguration<BookAuthor>
    {
        public void Configure(EntityTypeBuilder<BookAuthor> builder)
        {
            
            builder.HasKey(bookauthors => new { bookauthors.BookId, bookauthors.AuthorId });

            
            builder.HasOne(bookauthors => bookauthors.Book)
                .WithMany(book => book.BookAuthors)
                .HasForeignKey(bookauthors => bookauthors.BookId);

            
            builder.HasOne(bookauthors => bookauthors.Author)
                .WithMany(author => author.BookAuthors)
                .HasForeignKey(bookauthors => bookauthors.AuthorId);

            // TABLE NAME
            builder.ToTable("BookAuthors");
        }
    }
}