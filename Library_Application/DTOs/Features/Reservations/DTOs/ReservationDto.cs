namespace Library.Application.DTOs.Features.Reservations.DTOs
{
    public class ReservationDto
    {
        public int Id { get; set; }

        public DateTime ReservationDate { get; set; }

        public DateTime ExpirationDate { get; set; }

        public string Status { get; set; }

        public int UserId { get; set; }

        public int BookId { get; set; }
    }
}