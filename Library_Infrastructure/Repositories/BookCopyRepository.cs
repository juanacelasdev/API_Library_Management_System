using Library.Application.Interfaces.Repositories;
using Library.Domain.Entities;
using Library.Infrastructure.Persistence.DBContext;
using Microsoft.EntityFrameworkCore;

namespace Library.Infrastructure.Repositories
{
    public class BookCopyRepository : IBookCopyRepository
    {
        private readonly LibraryDbContext _context;

        public BookCopyRepository(LibraryDbContext context)
        {
            _context = context;
        }

        public async Task<BookCopy?> GetByIdAsync(int id)
        {
            return await _context.BookCopies
                .Include(BookCopy => BookCopy.Book)
                .FirstOrDefaultAsync(bc => bc.Id == id);
        }

        public async Task<IEnumerable<BookCopy>> GetAllAsync()
        {
            return await _context.BookCopies
                .ToListAsync();
        }

        public async Task<IEnumerable<BookCopy>> GetAvailableCopiesAsync()
        {
            return await _context.BookCopies
                .Where(BookCopy => BookCopy.IsActive)
                .ToListAsync();
        }

        public async Task AddAsync(BookCopy bookCopy)
        {
            await _context.BookCopies.AddAsync(bookCopy);

            await _context.SaveChangesAsync();
        }

        public async Task UpdateAsync(BookCopy bookCopy)
        {
            _context.BookCopies.Update(bookCopy);

            await _context.SaveChangesAsync();
        }

        public async Task DeleteAsync(BookCopy bookCopy)
        {
            _context.BookCopies.Remove(bookCopy);

            await _context.SaveChangesAsync();
        }

        public async Task<IEnumerable<BookCopy>> GetByBookIdAsync(int bookId)
        {
            return await _context.BookCopies
                .Where(BookCopy => BookCopy.BookId == bookId)
                .Include(BookCopy => BookCopy.Book)
                .ToListAsync();
        }
    }
}