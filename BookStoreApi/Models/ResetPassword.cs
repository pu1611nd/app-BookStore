using System.ComponentModel.DataAnnotations;

namespace BookStoreApi.Models
{
    public class ResetPassword
    {
        [Required]
        public string Password { get; set; } = null!;
        [Compare("Password",ErrorMessage ="password va confipass khong trung nhau")]
        public string ConfirmPassword { get; set;} = null!;
        public string Email { get; set; } = null!;
        public string Token { get; set; } = null!;
    }
}
