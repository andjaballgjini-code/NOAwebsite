using System.ComponentModel.DataAnnotations;

namespace NOA_Library.Models
{
    public class Rating
    {
        public int Id { get; set; } // ID e vlerësimit

        [Required]
        public int BookId { get; set; } // Lidhja me librin

        [Range(1, 5, ErrorMessage = "Rating must be between 1 and 5 stars.")]
        public int Stars { get; set; } // Yjet e vlerësimit
    }
}

