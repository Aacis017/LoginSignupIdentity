using System.ComponentModel.DataAnnotations;

namespace ManuallyLoginSIgnuP.ViewModel
{
    public class RegisterViewModel
    {
        
        [EmailAddress]
        public string Email { get; set; }
        [Required]
        [DataType(DataType.Password)]
        public string Password { get; set; }
        [Required]
        [DataType(DataType.Password)]
        [Compare("Password",ErrorMessage ="Password and ConfirmPassword doesn't match")]
        public string ConfirmPassword { get; set; }
    }
}
