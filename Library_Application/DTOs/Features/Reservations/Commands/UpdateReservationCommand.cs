using System.ComponentModel.DataAnnotations;

namespace Library.Application.DTOs.Features.Reservations.Commands
{
    public class UpdateReservationCommand
    {
        public int Id { get; set; }

        [Required]
        public DateTime ReservationDate { get; set; }

        [Required]
        public DateTime ExpirationDate { get; set; }

        [Required]
        public int Status { get; set; }

        [Required]
        public int UserId { get; set; }

        [Required]
        public int BookId { get; set; }
    }
}