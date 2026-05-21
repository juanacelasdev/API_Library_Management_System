using Library.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Library.Infrastructure.Persistence.Configurations
{
    public class ReservationConfigurations : IEntityTypeConfiguration<Reservation>
    {
        public void Configure(EntityTypeBuilder<Reservation> builder)
        {
            
            builder.HasKey(reservation => reservation.Id);

            builder.Property(reservation => reservation.ReservationDate)
                .IsRequired();

            builder.Property(reservation => reservation.ExpirationDate)
                .IsRequired();

            builder.Property(reservation => reservation.Status)
                .IsRequired();

            builder.HasOne(reservation => reservation.User)
                .WithMany(user => user.Reservations)
                .HasForeignKey(reservation => reservation.UserId)
                .OnDelete(DeleteBehavior.Restrict);

            builder.HasOne(reservation => reservation.Book)
                .WithMany(book => book.Reservations)
                .HasForeignKey(reservation => reservation.BookId)
                .OnDelete(DeleteBehavior.Restrict);

            builder.ToTable("Reservations");
        }
    }
}