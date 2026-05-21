using Library.Domain.Entities;

namespace Library.Application.Interfaces.Repositories
{
    public interface IAuthorRepository
    {
        Task<Author?> GetByIdAsync(int id);

        Task<IEnumerable<Author>> GetAllAsync();

        Task AddAsync(Author author);

        Task UpdateAsync(Author author);

        Task DeleteAsync(Author author);
    }
}