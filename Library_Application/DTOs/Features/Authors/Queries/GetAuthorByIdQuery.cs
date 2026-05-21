namespace Library.Application.Features.Authors.Queries
{
    public class GetAuthorByIdQuery
    {
        public int Id { get; set; }

        public GetAuthorByIdQuery(int id)
        {
            Id = id;
        }
    }
}