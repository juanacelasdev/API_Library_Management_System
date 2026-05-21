namespace Library.Application.DTOs.Features.Reservations.Queries
{
    public class GetReservationByIdQuery
    {
        public int Id { get; set; }

        public GetReservationByIdQuery(int id)
        {
            Id = id;
        }
    }
}