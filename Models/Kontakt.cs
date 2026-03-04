using Microsoft.AspNetCore.Mvc;
using NOA_Library.Validations;
using System.ComponentModel.DataAnnotations;

namespace NOA_Library.Models
{
    public class Kontakt
    {
        [Required(ErrorMessage = "Fill In Your Name!")]
        [StringLength(20)]
        [NameValidation]
        public string? Name { get; set; }
        [Required]
        [EmailValidation]
        public string? Email { get; set; }
        [Required(ErrorMessage = "Fill In Your Request Or Complain!")]
        public string? Message { get; set; }


    }

}