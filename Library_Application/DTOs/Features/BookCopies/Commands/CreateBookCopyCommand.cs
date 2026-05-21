using System.ComponentModel.DataAnnotations;

namespace Library.Application.DTOs.Features.BookCopies.Commands
{
    public class CreateBookCopyCommand
    {
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