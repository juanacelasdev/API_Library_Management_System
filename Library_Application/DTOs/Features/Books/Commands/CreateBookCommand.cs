using System.ComponentModel.DataAnnotations;

namespace Library.Application.DTOs.Features.Books.Commands
{
    public class CreateBookCommand
    {
        [Required]
        [MaxLength(150)]
        public string Title { get; set; }

        [Required]
        public int YearOfPublication { get; set; }

        [Required]
        [MaxLength(50)]
        public string ISBN { get; set; }

        [Required]
        public decimal Price { get; set; }

        [Required]
        public int CategoryId { get; set; }
    }
}