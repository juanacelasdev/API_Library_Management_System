using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Library.Domain.Entities;

namespace Library.Application.Interfaces.Repositories
{
    public interface IReservationRepository
    {
        Task<Reservation?> GetByIdAsync (int id);
        Task<IEnumerable<Reservation>> GetAllAsync();
        Task<IEnumerable<Reservation>> GetReservationsByUserIdAsync(int userId);
        Task<IEnumerable<Reservation>> GetActiveReservationsAsync();
        Task AddAsync(Reservation reservation);
        Task UpdateAsync (Reservation reservation);
        Task DeleteAsync (int id);

    }
}
