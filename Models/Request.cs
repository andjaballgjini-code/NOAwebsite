using System.ComponentModel.DataAnnotations;
using NOA_Library.Validations;

namespace NOA_Library.Models
{
    public class Request
    {
        [Required]
        [EmailValidation]
        public string? Email { get; set; }
        [Required]
        [NameValidation]
        public string? BookTitle { get; set; }
        [Required]
        [NameValidation]
        public string? Author { get; set; }
    }
}