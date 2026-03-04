using Microsoft.AspNetCore.Mvc;
using NOA_Library.Models;
using NOA_Library.Repositories;
using System.Linq;

namespace NOA.Controllers
{
    public class BooksController : Controller
    {
        private readonly BookRepository _bookRepository;

        public BooksController()
        {
            _bookRepository = new BookRepository();
        }

        // Function to display books and search option
        public IActionResult Index(string searchQuery, string genre)
        {
            var books = _bookRepository.GetAllBooks();

            // Search by keyword
            if (string.IsNullOrEmpty(genre) && !string.IsNullOrEmpty(searchQuery))
            {
                books = books
                    .Where(b => b.Title.Contains(searchQuery, System.StringComparison.OrdinalIgnoreCase) ||
                                b.Author.Contains(searchQuery, System.StringComparison.OrdinalIgnoreCase))
                    .ToList();
                ViewData["SearchQuery"] = searchQuery;
            }

            // Filter by genre (check if genre exists in the book's genre list)
            if (!string.IsNullOrEmpty(genre))
            {
                books = books
                    .Where(b => b.Genre
                        .Split(',', StringSplitOptions.RemoveEmptyEntries) // Split genres into a list
                        .Any(z => z.Trim().Equals(genre, System.StringComparison.OrdinalIgnoreCase))) // Check each genre
                    .ToList();
                ViewData["Genre"] = genre;
            }

            // Message if no results
            if (!books.Any())
            {
                ViewData["Message"] = "No books match your search.";
            }

            return View(books);
        }

        // Function to display details of a single book
        public IActionResult Details(int id)
        {
            var book = _bookRepository.GetBookById(id);
            if (book == null)
            {
                return NotFound();
            }
            return View(book);
        }

        // Function to display books by genre
        public IActionResult FilterByGenre(string genre)
        {
            var booksByGenre = _bookRepository.GetBooksByGenre(genre);

            if (!booksByGenre.Any())
            {
                ViewData["Message"] = $"No books found for the genre '{genre}'";
            }

            ViewData["Genre"] = genre;
            return View("BooksByGenre", booksByGenre);
        }
    }
}
