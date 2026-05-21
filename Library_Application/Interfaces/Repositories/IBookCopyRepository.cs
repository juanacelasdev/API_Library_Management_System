using Library.Domain.Entities;

namespace Library.Application.Interfaces.Repositories
{
    public interface IBookCopyRepository
    {
        Task<BookCopy?> GetByIdAsync(int id);
        Task<IEnumerable<BookCopy>> GetAllAsync();

        Task<IEnumerable<BookCopy>> GetAvailableCopiesAsync();

        Task<IEnumerable<BookCopy>> GetByBookIdAsync(int bookId);
        

        Task AddAsync(BookCopy bookCopy);

        Task UpdateAsync(BookCopy bookCopy);

        Task DeleteAsync(BookCopy bookCopy);
    }
}
