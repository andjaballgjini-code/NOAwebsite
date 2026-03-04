using System.ComponentModel.DataAnnotations;

namespace NOA_Library.ViewModels
{
    public class ChangePasswordViewModel
    {
        [Required(ErrorMessage = "Email is required")]
        public string Email { get; set; }
        [EmailAddress]

        [Required(ErrorMessage = "Password is required")]
        [DataType(DataType.Password)]
        [Display(Name = "New Password")]
        public string NewPassword { get; set; }

        [StringLength(10, MinimumLength = 8, ErrorMessage = "The {0} must be at least {2} and at max {1} characters long")]
        [Compare("ConfirmNewPassword", ErrorMessage = "The Password do not match!")]
        [Required(ErrorMessage = "Confirm Password is required")]
        [DataType(DataType.Password)]
        [Display(Name = "Confirm New Password")]

        public string ConfirmNewPassword { get; set; }
    }
}
