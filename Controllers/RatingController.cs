using Microsoft.AspNetCore.Mvc;
using NOA_Library.Models;
using NOA_Library.Repositories;

namespace NOA_Library.Controllers
{
    public class RatingController : Controller
    {
        private readonly BookRepository _bookRepository;

        public RatingController()
        {
            _bookRepository = new BookRepository();
        }

        [HttpPost]
        public IActionResult AddRating(int bookId, int stars)
        {
            if (stars < 1 || stars > 5)
            {
                TempData["Error"] = "Rating must be between 1 and 5 stars.";
                return RedirectToAction("Details", "Books", new { id = bookId });
            }

            var book = _bookRepository.GetBookById(bookId);
            if (book == null)
            {
                return NotFound();
            }

            // Shto vlerësimin për librin
            _bookRepository.AddRating(bookId, new Rating { BookId = bookId, Stars = stars });

            TempData["Success"] = "Thank you for your rating!";
            return RedirectToAction("Details", "Books", new { id = bookId });
        }
    }
}
