namespace Library.Application.DTOs.Features.Loans.Queries
{
    public class GetLoanByIdQuery
    {
        public int Id { get; set; }

        public GetLoanByIdQuery(int id)
        {
            Id = id;
        }
    }
}