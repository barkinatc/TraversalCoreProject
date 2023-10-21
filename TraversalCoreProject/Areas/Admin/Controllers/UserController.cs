using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Project.Business.Abstract;
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
        IAppUserService _appUserService;
        IReservationService _rezervationService;

        public UserController(IAppUserService appUserService, IReservationService rezervationService)
        {
            _appUserService = appUserService;
            _rezervationService = rezervationService;
        }

        public IActionResult ListUsers()
        {
            List<AdminAppUserVM> users = _appUserService.TGetList().Select(x => new AdminAppUserVM

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

        public IActionResult DeleteUser(int id)
        {
            //var user= await (_userManager.FindByIdAsync(id.ToString()));
            // if (user ==null)
            // {
            //     return View();
            // }
            // var result = await _userManager.DeleteAsync(user);
            // if (result.Succeeded)
            // {
            //     TempData["SuccessMessage"] = "Islem basariyla gerceklesmistir.";
            //     return Redirect("/Admin/User/ListUsers");

            // }
            // ModelState.AddModelError("User", "Kullanıcı Silinemedi.");
            // //HATA mesajı çıkartıcam

            var user = _appUserService.TFind( id);

            if (user!=null)
            {
                _appUserService.TDelete(user);
                TempData["SuccessMessage"] = "Islem basariyla gerceklesmistir.";
                return Redirect("/Admin/User/ListUsers");

            }
            ModelState.AddModelError("User", "Kullanıcı Silinemedi.");
            return View();
        }
        public IActionResult GetReservationHistory(int id)
        {
            List<AdminReservationVM> values = _rezervationService.TGetList().Where(x => x.AppUserID == id).Select(x => new AdminReservationVM
            {
                ID = x.ID,
                DestinationID = x.DestinationID,
                DestinationName =x.Destination.City,
                Description = x.Description,
                //AppUserName = x.AppUser.Name,
                //AppUserSurName = x.AppUser.Surname,
                RezervasyonDurumu = x.RezervasyonDurumu,
                CreatedDate = x.CreatedDate

            }).ToList();
            return View(values);
        }
    }
}
