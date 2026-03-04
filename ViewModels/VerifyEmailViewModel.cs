using System.ComponentModel.DataAnnotations;

namespace NOA_Library.ViewModels
{
    public class VerifyEmailViewModel
    {
        [Required(ErrorMessage = "Email is required")]
        [EmailAddress]

        public string Email { get; set; }

    }
}