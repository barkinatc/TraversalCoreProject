using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TraversalCoreProject.ViewModels
{
    public class UserEditVM
    {
       

        public string Name { get; set; }
        public string Surname { get; set; }
        public string Password { get; set; }
        public string ConfirmPassword { get; set; }
        public string PhoneNo { get; set; }
        public string Mail { get; set; }
        public string ImageUrl { get; set; }
        public string Gender { get; set; }

        public IFormFile    Image { get; set; }

    }
}
