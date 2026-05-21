using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Library.Domain.Entities;

namespace Library.Application.Interfaces.Repositories
{
    public interface ILoanRepository
    {
        Task<Loan?> GetByIdAsync(int id);

        Task<IEnumerable<Loan>> GetAllAsync();

        Task<IEnumerable<Loan>> GetLoansByUserIdAsync(int userId);

        Task<IEnumerable<Loan>> GetActiveLoansAsync();

        Task<IEnumerable<Loan>> GetOverdueLoansAsync();

        Task AddAsync(Loan loan);

        Task UpdateAsync(Loan loan);

        Task DeleteAsync(Loan loan);
    }
}
