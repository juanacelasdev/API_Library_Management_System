using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Library.Domain.Entities;

namespace Library.Application.Interfaces.Repositories
{
    public interface IUserRepository
    {
        Task<User?>  GetByIdAsync (int id);
        Task<IEnumerable<User>> GetAllAsync ();
        Task<User?> GetByEmailAsync(string email);
        Task<IEnumerable<User>> GetActiveUserAsync();
        Task AddAsync(User User);
        Task UpdateAsync(User User);
        Task DeleteAsync(User User);


    }
}
