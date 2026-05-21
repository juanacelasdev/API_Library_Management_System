namespace Library.Application.DTOs.Features.BookCopies.DTOs
{
    public class BookCopyDto
    {
        public int Id { get; set; }

        public string InventoryCode { get; set; }

        public string Status { get; set; }

        public bool IsActive { get; set; }

        public int BookId { get; set; }
    }
}