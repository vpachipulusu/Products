using System.ComponentModel.DataAnnotations;

namespace Products.Web.Models
{
    public class PasswordInputViewModel
    {
        [Required]
        [StringLength(
            ModelValidations.Password.PasswordMaxLength,
            ErrorMessage = ModelValidations.Error.RangeMessage,
            MinimumLength = ModelValidations.Password.PasswordMinLength)]
        public string Password { get; set; }

        public string Error { get; set; }
    }
}
