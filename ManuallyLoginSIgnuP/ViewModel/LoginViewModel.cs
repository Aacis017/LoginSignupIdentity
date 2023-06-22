using System.ComponentModel.DataAnnotations;

namespace ManuallyLoginSIgnuP.ViewModel
{
    public class LoginViewModel
    {
        [EmailAddress]
        public string Email { get; set; }
        [Required]
        [DataType(DataType.Password)]
        public string Password { get; set; }

        [Display(Name ="Remember Me")]
        public bool RememberMe { get; set; }    
    }
}
