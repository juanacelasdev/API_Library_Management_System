using Library.Application.Interfaces.Repositories;
using Library.Domain.Entities;
using Library.Domain.Enums;
using Library.Infrastructure.Persistence.DBContext;
using Microsoft.EntityFrameworkCore;

namespace Library.Infrastructure.Repositories
{
    public class ReservationRepository : IReservationRepository
    {
        private readonly LibraryDbContext _context;

        public ReservationRepository(LibraryDbContext context)
        {
            _context = context;
        }

        public async Task<Reservation?> GetByIdAsync(int id)
        {
            return await _context.Reservations
                .Include(reservation => reservation.User)
                .Include(reservation => reservation.Book)
                .FirstOrDefaultAsync(reservation => reservation.Id == id);
        }

        public async Task<IEnumerable<Reservation>> GetAllAsync()
        {
            return await _context.Reservations
                .Include(reservation => reservation.User)
                .Include(reservation => reservation.Book)
                .ToListAsync();
        }

        public async Task<IEnumerable<Reservation>> GetReservationsByUserIdAsync(int userId)
        {
            return await _context.Reservations
                .Where(reservation => reservation.UserId == userId)
                .Include(reservation => reservation.User)
                .Include(reservation => reservation.Book)
                .ToListAsync();
        }

        public async Task<IEnumerable<Reservation>> GetActiveReservationsAsync()
        {
            return await _context.Reservations
                .Where(reservation => reservation.Status == ReservationStatus.Pending)
                .Include(reservation => reservation.User)
                .Include(reservation => reservation.Book)
                .ToListAsync();
        }

        public async Task AddAsync(Reservation reservation)
        {
            await _context.Reservations.AddAsync(reservation);

            await _context.SaveChangesAsync();
        }

        public async Task UpdateAsync(Reservation reservation)
        {
            _context.Reservations.Update(reservation);

            await _context.SaveChangesAsync();
        }

        public async Task DeleteAsync(int id)
        {
            var reservation = await _context.Reservations
                .FirstOrDefaultAsync(reservation => reservation.Id == id);

            if (reservation != null)
            {
                _context.Reservations.Remove(reservation);

                await _context.SaveChangesAsync();
            }
        }
    }
}