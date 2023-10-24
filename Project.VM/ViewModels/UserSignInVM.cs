using System.ComponentModel.DataAnnotations;

namespace Project.VM.ViewModels
{
    public class UserSignInVM
    {
        [Required]
        public string UserName { get; set; }
        [Required]
        public string Password { get; set; }

    }
}
