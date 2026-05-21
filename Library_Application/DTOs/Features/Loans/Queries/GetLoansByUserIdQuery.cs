namespace Library.Application.DTOs.Features.Loans.Queries
{
    public class GetLoansByUserIdQuery
    {
        public int UserId { get; set; }

        public GetLoansByUserIdQuery(int userId)
        {
            UserId = userId;
        }
    }
}