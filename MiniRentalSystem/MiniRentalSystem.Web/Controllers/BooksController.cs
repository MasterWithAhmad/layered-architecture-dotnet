// Title: BooksController.cs
// Author: Ahmed Ibrahim
// Date: 2025-04-15
// Description: Handles book-related HTTP actions.

using Microsoft.AspNetCore.Mvc;
using MiniRentalSystem.Application.Interfaces;
using MiniRentalSystem.Domain.Entities;

namespace MiniRentalSystem.Web.Controllers
{
    public class BooksController : Controller
    {
        private readonly IBookService _bookService;

        public BooksController(IBookService bookService)
        {
            _bookService = bookService;
        }

        public async Task<IActionResult> Index()
        {
            var books = await _bookService.GetAllAsync();
            return View(books);
        }

        [HttpPost]
        public async Task<IActionResult> Create(Book book)
        {
            if (ModelState.IsValid)
            {
                await _bookService.AddAsync(book);
                return Json(new { success = true, message = "Book added successfully." });
            }

            return PartialView("_CreateOrEdit", book);
        }

        public IActionResult Create()
        {
            return PartialView("_CreateOrEdit", new Book());
        }

        public async Task<IActionResult> Edit(Guid id)
        {
            var book = await _bookService.GetByIdAsync(id);
            if (book == null)
                return NotFound();

            return PartialView("_CreateOrEdit", book);
        }

        [HttpPost]
        public async Task<IActionResult> Edit(Book book)
        {
            if (ModelState.IsValid)
            {
                await _bookService.UpdateAsync(book);
                return Json(new { success = true, message = "Book updated successfully." });
            }

            return PartialView("_CreateOrEdit", book);
        }

        [HttpPost]
        public async Task<IActionResult> Delete(Guid id)
        {
            await _bookService.DeleteAsync(id);
            return Json(new { success = true, message = "Book deleted successfully." });
        }
    }
}

