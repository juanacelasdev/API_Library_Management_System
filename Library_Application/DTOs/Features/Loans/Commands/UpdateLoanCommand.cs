using System.ComponentModel.DataAnnotations;

namespace Library.Application.DTOs.Features.Loans.Commands
{
    public class UpdateLoanCommand
    {
        public int Id { get; set; }

        [Required]
        public DateTime LoanDate { get; set; }

        [Required]
        public DateTime DueDate { get; set; }

        public DateTime? ReturnDate { get; set; }

        [Required]
        public int Status { get; set; }

        [Required]
        public int UserId { get; set; }

        [Required]
        public int BookCopyId { get; set; }
    }
}