namespace Library.Application.DTOs.Features.Loans.DTOs
{
    public class LoanDto
    {
        public int Id { get; set; }

        public DateTime LoanDate { get; set; }

        public DateTime DueDate { get; set; }

        public DateTime? ReturnDate { get; set; }

        public int Status { get; set; }

        public int UserId { get; set; }

        public int BookCopyId { get; set; }
    }
}