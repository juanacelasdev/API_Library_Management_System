namespace Library.Application.DTOs.Features.Books.Queries
{
    public class GetBookByIdQuery
    {
        public int Id { get; set; }

        public GetBookByIdQuery(int id)
        {
            Id = id;
        }
    }
}