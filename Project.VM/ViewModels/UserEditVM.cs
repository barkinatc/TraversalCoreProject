
using Microsoft.AspNetCore.Http;

namespace Project.VM.ViewModels
{
    public class UserEditVM
    {

        public int ID { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Password { get; set; }
        public string ConfirmPassword { get; set; }
        public string PhoneNo { get; set; }
        public string Mail { get; set; }
        public string ImageUrl { get; set; }
        public string Gender { get; set; }

        public IFormFile Image { get; set; }

    }
}
