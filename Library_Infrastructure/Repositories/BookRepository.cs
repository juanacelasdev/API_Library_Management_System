using Library.Application.Interfaces.Repositories;
using Library.Domain.Entities;
using Library.Infrastructure.Persistence.DBContext;
using Microsoft.EntityFrameworkCore;

namespace Library.Infrastructure.Repositories
{
    public class BookRepository : IBookRepository
    {
        private readonly LibraryDbContext _context;

        public BookRepository(LibraryDbContext context)
        {
            _context = context;
        }

        public async Task<Book?> GetByIdAsync(int id)
        {
            return await _context.Books
                .Include(book => book.Category)
                .Include(book => book.BookAuthors)
                    .ThenInclude(bookauthor => bookauthor.Author)
                .FirstOrDefaultAsync(book => book.Id == id);
        }

        public async Task<IEnumerable<Book>> GetAllAsync()
        {
            return await _context.Books
                .Include(book => book.Category)
                .Include(book => book.BookAuthors)
                    .ThenInclude(bookauthor => bookauthor.Author)
                .ToListAsync();
        }

        public async Task AddAsync(Book book)
        {
            await _context.Books.AddAsync(book);

            await _context.SaveChangesAsync();
        }

        public async Task UpdateAsync(Book book)
        {
            _context.Books.Update(book);

            await _context.SaveChangesAsync();
        }

        public async Task DeleteAsync(Book book)
        {
            _context.Books.Remove(book);

            await _context.SaveChangesAsync();
        }

        public async Task<IEnumerable<Book>> SearchAsync(string term)
        {
            return await _context.Books
                .Where(book => book.Title.Contains(term))
                .ToListAsync();
        }
    }
}