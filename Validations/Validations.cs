using System.ComponentModel.DataAnnotations;
using System.Text.RegularExpressions;

namespace NOA_Library.Validations
{
    public class EmailValidation : ValidationAttribute
    {
        protected override ValidationResult? IsValid(object? value, ValidationContext validationContext)
        {
            if (value == null || string.IsNullOrWhiteSpace(value.ToString()))
            {
                return new ValidationResult("Please Fill In Your Email.");
            }

            var email = value.ToString()?.Trim();

            if (string.IsNullOrEmpty(email))
            {
                return new ValidationResult("This Email Is Not Valid.");
            }


            var regex = new Regex(@"^[^@\s]+@[^@\s]+\.[^@\s]+$");

            if (!regex.IsMatch(email))
            {
                return new ValidationResult("This Email Is Not Valid.");
            }

            return ValidationResult.Success;
        }
    }
    public class NameValidation : ValidationAttribute
    {
        public NameValidation() : base("Name Should Start With An Upper Case.")
        {
        }

        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {
            if (value == null || string.IsNullOrWhiteSpace(value.ToString()))
            {
                return ValidationResult.Success;
            }

            var name = value.ToString()!;


            if (char.IsUpper(name[0]))
            {
                return ValidationResult.Success;
            }

            return new ValidationResult("The first letter of the name must be uppercase.");
        }
    }
}

