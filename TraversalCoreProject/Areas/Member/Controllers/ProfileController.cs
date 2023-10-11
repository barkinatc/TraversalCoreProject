using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Project.ENTITIES.Concrete;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

using TraversalCoreProject.ViewModels;

namespace TraversalCoreProject.Areas.Member.Controllers
{
    [Area("member")]
    [Route("Member/[controller]/[action]")]

    public class ProfileController : Controller
    {
        private readonly UserManager<AppUser> _userManager;

        public ProfileController(UserManager<AppUser> userManager)
        {
            _userManager = userManager;
        }
        [HttpGet]
        public async Task< IActionResult> Index()
        {
            var values = await _userManager.FindByNameAsync(User.Identity.Name);

            UserEditVM userEditVM = new UserEditVM
            {
                Name = values.Name,
                Surname = values.Surname,
                Mail = values.Email,
                PhoneNo = values.PhoneNumber
            };

            return View(userEditVM);
        }
        [HttpPost]

        public async Task<IActionResult> Index(UserEditVM p)
        {
            var user = await _userManager.FindByNameAsync(User.Identity.Name);

            if (p.Image!=null)
            {
                var resource = Directory.GetCurrentDirectory();
                var extension = Path.GetExtension(p.Image.FileName);
                var imagename = Guid.NewGuid() + extension;
                var savelocation = $"{resource}/Custom/UserImages/{ imagename}";
                var stream = new FileStream(savelocation, FileMode.Create);
                await p.Image.CopyToAsync(stream);
                user.ImageUrl = imagename;
            }
            user.Name = p.Name;
            user.Surname = p.Surname;
            user.PasswordHash = _userManager.PasswordHasher.HashPassword(user, p.Password);
            var result = await _userManager.UpdateAsync(user);

            if (result.Succeeded)
            {
                return RedirectToAction("SignIn","Login");
            }



            return View();
        }

        
    }
}
