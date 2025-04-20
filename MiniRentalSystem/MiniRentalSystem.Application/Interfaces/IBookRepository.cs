// Title: IBookRepository.cs
// Author: Ahmed Ibrahim
// Date: 2025-04-15
// Description: Contract for book-related data access operations.

using MiniRentalSystem.Domain.Entities;

namespace MiniRentalSystem.Application.Interfaces
{
    public interface IBookRepository
    {
        Task<IEnumerable<Book>> GetAllAsync();
        Task<Book?> GetByIdAsync(Guid id);
        Task AddAsync(Book book);
        Task UpdateAsync(Book book);
        Task DeleteAsync(Guid id);
    }
}
