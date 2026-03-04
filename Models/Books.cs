using System.ComponentModel.DataAnnotations;

namespace NOA_Library.Models
{
    public class Books
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Title is required.")]
        public string Title { get; set; }

        [Required(ErrorMessage = "Author is required.")]
        public string Author { get; set; }

        public string Publisher { get; set; }

        [Range(1, 2100, ErrorMessage = "Year must be valid.")]
        public string? Year { get; set; }

        [Range(1, int.MaxValue, ErrorMessage = "Pages must be greater than 0.")]
        public int? Pages { get; set; }

        public string Language { get; set; }
        public string Genre { get; set; }
        public string ImageUrl { get; set; }
        public string Description { get; set; }
        public List<Rating> Ratings { get; set; } = new List<Rating>();

        // Llogaritja e mesatares së vlerësimeve
        public double AverageRating => Ratings.Any() ? Ratings.Average(r => r.Stars) : 0;
        public int TotalRatings => Ratings.Count;
    }
}


