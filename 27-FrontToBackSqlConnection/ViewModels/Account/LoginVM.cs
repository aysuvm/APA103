using System.ComponentModel.DataAnnotations;

namespace FrontToBack.ViewModels.Account
{
    public class LoginVM
    {
        [MinLength(4)]
        [MaxLength(50)]
        [Required]
        public string UsernameOrEmail { get; set; }

        [Required]
        public string Password { get; set; }

        public bool IsPersistent { get; set; }
    }
}