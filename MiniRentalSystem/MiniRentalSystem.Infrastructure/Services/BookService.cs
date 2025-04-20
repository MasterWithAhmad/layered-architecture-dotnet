// Title: BookService.cs
// Author: Ahmed Ibrahim
// Date: 2025-04-15
// Description: Implements business logic for book-related operations.

using MiniRentalSystem.Domain.Entities;
using MiniRentalSystem.Application.Interfaces;

namespace MiniRentalSystem.Application.Services
{
    public class BookService : IBookService
    {
        private readonly IBookRepository _bookRepository;

        public BookService(IBookRepository bookRepository)
        {
            _bookRepository = bookRepository;
        }

        public async Task<IEnumerable<Book>> GetAllAsync()
        {
            return await _bookRepository.GetAllAsync();
        }

        public async Task<Book?> GetByIdAsync(Guid id)
        {
            return await _bookRepository.GetByIdAsync(id);
        }

        public async Task AddAsync(Book book)
        {
            // Optional: Add business rules here (e.g., ISBN must be unique)
            await _bookRepository.AddAsync(book);
        }

        public async Task UpdateAsync(Book book)
        {
            var existingBook = await _bookRepository.GetByIdAsync(book.Id);
            if (existingBook is null)
                throw new InvalidOperationException("Book not found.");

            await _bookRepository.UpdateAsync(book);
        }

        public async Task DeleteAsync(Guid id)
        {
            var existingBook = await _bookRepository.GetByIdAsync(id);
            if (existingBook is null)
                throw new InvalidOperationException("Cannot delete non-existent book.");

            await _bookRepository.DeleteAsync(id);
        }
    }
}