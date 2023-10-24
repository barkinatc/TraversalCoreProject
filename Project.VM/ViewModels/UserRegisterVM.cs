using System.ComponentModel.DataAnnotations;

namespace Project.VM.ViewModels
{
    public class UserRegisterVM
    {
        [Required]
        public string Name { get; set; }
        [Required]
        public string SurName { get; set; }
        [Required]
        public string UserName { get; set; }
        [Required]
        public string Mail { get; set; }
        [Required]
        public string Password { get; set; }
        [Required]
        [Compare("Password", ErrorMessage = "Şifreler uyumlu değildir")]
        public string ConfirmPassword { get; set; }


    }
}
