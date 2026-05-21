namespace Library.Application.DTOs.Features.Reservations.Queries
{
    public class GetReservationsByUserIdQuery
    {
        public int UserId { get; set; }

        public GetReservationsByUserIdQuery(int userId)
        {
            UserId = userId;
        }
    }
}