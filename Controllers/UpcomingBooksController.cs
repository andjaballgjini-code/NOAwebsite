using Microsoft.AspNetCore.Mvc;
using NOA_Library.Models;
using System;
using System.Collections.Generic;

namespace NOA_Library.Controllers
{
    public class UpcomingBooksController : Controller
    {
        // Static list to store upcoming books
        private static List<UpcomingBook> _upcomingBooks = new List<UpcomingBook>
        {
            new UpcomingBook { Title = "The Great Escape", Author = "John Doe", ReleaseDate = new DateTime(2025, 2, 15), Description = "A thrilling escape story." },
            new UpcomingBook { Title = "Future Horizons", Author = "Jane Smith", ReleaseDate = new DateTime(2025, 3, 10), Description = "An exploration of new technologies." }
        };

        public IActionResult Index()
        {
            return View(_upcomingBooks);
        }

        // Admin can add a new upcoming book
        [HttpPost]
        public IActionResult AddUpcomingBook(string title, string author, DateTime releaseDate, string description)
        {
            // Only the admin can add books
            if (User.Identity.Name == "noa_libadmin@gmail.com")
            {
                _upcomingBooks.Add(new UpcomingBook { Title = title, Author = author, ReleaseDate = releaseDate, Description = description });
                TempData["Success"] = "Upcoming book added successfully!";
            }
            else
            {
                TempData["Error"] = "You do not have permission to add books.";
            }

            return RedirectToAction("Index");
        }
    }
}