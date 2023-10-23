using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Project.ENTITIES.Concrete;
using System;
using System.IO;
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
        public async Task<IActionResult> MyProfile()
        {
            var values = await _userManager.FindByNameAsync(User.Identity.Name);

            ViewBag.v = values;

            return View();
        }
        [HttpGet]
        public async Task<IActionResult> EditProfile()
        {
            var values = await _userManager.FindByNameAsync(User.Identity.Name);


            UserEditVM userEditVM = new UserEditVM
            {
                Name = values.Name,
                Surname = values.Surname,
                Mail = values.Email,
                PhoneNo = values.PhoneNumber,
                Gender = values.Gender

            };

            return View(userEditVM);
        }
        [HttpPost]

        public async Task<IActionResult> EditProfile(UserEditVM p)
        {
            var user = await _userManager.FindByNameAsync(User.Identity.Name);

            if (p.Image != null)
            {
                var resource = Directory.GetCurrentDirectory();
                var extension = Path.GetExtension(p.Image.FileName);
                var imagename = Guid.NewGuid() + extension;
                var savelocation = $"{resource}/wwwroot/UserImages/{imagename}";
                var stream = new FileStream(savelocation, FileMode.Create);
                await p.Image.CopyToAsync(stream);
                user.ImageUrl = imagename;
            }
            user.Name = p.Name;
            user.Surname = p.Surname;
            user.Gender = p.Gender;
            user.Email = p.Mail;
            user.PhoneNumber = p.PhoneNo;
            //if (string.IsNullOrEmpty(user.PasswordHash))
            //{

            //}

            if (string.IsNullOrEmpty(p.Password))
            {

                ModelState.AddModelError("Password", "Lütfen parola giriniz.");
                return View();
            }
            else if (string.IsNullOrEmpty(p.ConfirmPassword))
            {
                ModelState.AddModelError("ConfirmPassword", "Lütfen parolanızı tekrar giriniz.");
                return View();
            }
            else if (p.Password != p.ConfirmPassword)
            {
                ModelState.AddModelError("WrongConfirmPassword", "Girdiğiniz parolalar birbirinden farklıdır.");
                return View();
            }
            user.PasswordHash = _userManager.PasswordHasher.HashPassword(user, p.Password);
            var result = await _userManager.UpdateAsync(user);


            if (result.Succeeded)
            {

                TempData["SuccessMessage"] = "Islem basariyla gerceklesmistir.";
                return View();
            }



            return View();
        }


    }
}
