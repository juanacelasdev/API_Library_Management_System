using Library.Application.Interfaces.Repositories;
using Library.Domain.Entities;
using Library.Domain.Enums;
using Library.Infrastructure.Persistence.DBContext;
using Microsoft.EntityFrameworkCore;

namespace Library.Infrastructure.Repositories
{
    public class LoanRepository : ILoanRepository
    {
        private readonly LibraryDbContext _context;

        public LoanRepository(LibraryDbContext context)
        {
            _context = context;
        }

        public async Task<Loan?> GetByIdAsync(int id)
        {
            return await _context.Loans
                .Include(loan => loan.User)
                .Include(loan => loan.BookCopy)
                    .ThenInclude(bookcopy => bookcopy.Book)
                .FirstOrDefaultAsync(loan => loan.Id == id);
        }

        public async Task<IEnumerable<Loan>> GetAllAsync()
        {
            return await _context.Loans
                .Include(loan => loan.User)
                .Include(loan => loan.BookCopy)
                    .ThenInclude(bookcopy => bookcopy.Book)
                .ToListAsync();
        }

        public async Task<IEnumerable<Loan>> GetLoansByUserIdAsync(int userId)
        {
            return await _context.Loans
                .Where(loan => loan.UserId == userId)
                .Include(loan => loan.User)
                .Include(loan => loan.BookCopy)
                    .ThenInclude(bookcopy => bookcopy.Book)
                .ToListAsync();
        }

        public async Task<IEnumerable<Loan>> GetActiveLoansAsync()
        {
            return await _context.Loans
                .Where(loan => loan.Status == LoadStatus.Active)
                .Include(loan => loan.User)
                .Include(loan => loan.BookCopy)
                    .ThenInclude(bookcopy => bookcopy.Book)
                .ToListAsync();
        }

        public async Task<IEnumerable<Loan>> GetOverdueLoansAsync()
        {
            return await _context.Loans
                .Where(loan =>
                    loan.DueDate < DateTime.UtcNow &&
                    loan.Status == LoadStatus.Active)
                .Include(loan => loan.User)
                .Include(loan => loan.BookCopy)
                    .ThenInclude(bookcopy => bookcopy.Book)
                .ToListAsync();
        }

        public async Task AddAsync(Loan loan)
        {
            await _context.Loans.AddAsync(loan);

            await _context.SaveChangesAsync();
        }

        public async Task UpdateAsync(Loan loan)
        {
            _context.Loans.Update(loan);

            await _context.SaveChangesAsync();
        }

        public async Task DeleteAsync(Loan loan)
        {
            _context.Loans.Remove(loan);

            await _context.SaveChangesAsync();
        }
    }
}