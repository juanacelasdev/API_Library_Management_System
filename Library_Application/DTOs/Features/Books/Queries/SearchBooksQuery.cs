namespace Library.Application.DTOs.Features.Books.Queries
{
    public class SearchBooksQuery
    {
        public string Term { get; set; }

        public SearchBooksQuery(string term)
        {
            Term = term;
        }
    }
}