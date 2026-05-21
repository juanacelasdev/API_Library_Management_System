namespace Library.Application.DTOs.Features.Loans.Commands
{
    public class DeleteLoanCommand
    {
        public int Id { get; set; }

        public DeleteLoanCommand(int id)
        {
            Id = id;
        }
    }
}