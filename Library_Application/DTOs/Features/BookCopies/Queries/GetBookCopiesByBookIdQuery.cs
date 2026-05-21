namespace Library.Application.DTOs.Features.BookCopies.Queries
{
    public class GetBookCopiesByBookIdQuery
    {
        public int BookId { get; set; }

        public GetBookCopiesByBookIdQuery(int bookId)
        {
            BookId = bookId;
        }
    }
}