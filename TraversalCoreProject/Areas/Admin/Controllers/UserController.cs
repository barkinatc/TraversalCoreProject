using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Project.ENTITIES.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TraversalCoreProject.Areas.Admin.Models;

namespace TraversalCoreProject.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class UserController : Controller
    {
        UserManager<AppUser> _userManager;

        public UserController(UserManager<AppUser> userManager)
        {
            _userManager = userManager;
        }

        public IActionResult ListUsers()
        {
            List<AdminAppUserVM> users = _userManager.Users.Select(x => new AdminAppUserVM

            {
                ID = x.Id,
                Name = x.Name,
                Surname = x.Surname,
                PhoneNo = x.PhoneNumber,
                Gender = x.Gender,
                UserName =x.UserName,
                Email =x.Email


            }).ToList();
            return View(users);
        }

        public async Task<IActionResult> DeleteUser(int id)
        {
           var user= await (_userManager.FindByIdAsync(id.ToString()));
            if (user ==null)
            {
                return View();
            }
            var result = await _userManager.DeleteAsync(user);
            if (result.Succeeded)
            {
                TempData["SuccessMessage"] = "Islem basariyla gerceklesmistir.";
                return Redirect("/Admin/User/ListUsers");

            }
            ModelState.AddModelError("User", "Kullanıcı Silinemedi.");
            //HATA mesajı çıkartıcam
            return View();
        }
    }
}
