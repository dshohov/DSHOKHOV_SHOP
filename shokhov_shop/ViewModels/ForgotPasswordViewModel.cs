using System.ComponentModel.DataAnnotations;

namespace shokhov_shop.ViewModels
{
    public class ForgotPasswordViewModel
    {
        [Required]
        [EmailAddress]
        public string Email { get; set; }
    }
}
