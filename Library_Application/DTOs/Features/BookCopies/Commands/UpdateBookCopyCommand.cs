using System.ComponentModel.DataAnnotations;

namespace Library.Application.DTOs.Features.BookCopies.Commands
{
    public class UpdateBookCopyCommand
    {
        public int Id { get; set; }

        [Required]
        [MaxLength(50)]
        public string InventoryCode { get; set; }

        [Required]
        public int Status { get; set; }

        public bool IsActive { get; set; }

        [Required]
        public int BookId { get; set; }
    }
}