using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Library.Domain.Entities;



namespace Library.Application.Interfaces.Repositories
{
    public interface IBookRepository
    {
        Task<Book?> GetByIdAsync(int id);

        Task<IEnumerable<Book>> GetAllAsync();
         
        Task AddAsync(Book book);

        Task UpdateAsync(Book book);

        Task DeleteAsync(Book book);

        Task<IEnumerable<Book>> SearchAsync(string term);
    }
}
