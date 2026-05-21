namespace Library.Application.DTOs.Features.Books.DTos
{
    public class BookDto
    {
        public int Id { get; set; }

        public string Title { get; set; }

        public int YearOfPublication { get; set; }

        public string ISBN { get; set; }

        public decimal Price { get; set; }

        public int CategoryId { get; set; }
        public string CategoryName { get; set; }
    }
}