namespace Library.Application.DTOs.Features.BookCopies.Queries
{
    public class GetBookCopyByIdQuery
    {
        public int Id { get; set; }

        public GetBookCopyByIdQuery(int id)
        {
            Id = id;
        }
    }
}