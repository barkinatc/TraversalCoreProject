using Microsoft.AspNetCore.Mvc;
using Project.Business.Abstract;
using System.Collections.Generic;
using System.Linq;
using TraversalCoreProject.Areas.Admin.Models;

namespace TraversalCoreProject.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class UserController : Controller
    {
     private    readonly   IAppUserService _userService;
     private readonly   IReservationService _rezervationService;
     private readonly   ICommentService _commentService;

        public UserController(IAppUserService userService, IReservationService rezervationService, ICommentService commentService)
        {
            _userService = userService;
            _rezervationService = rezervationService;
            _commentService = commentService;
        }

        public IActionResult ListUsers()
        {
            List<AdminAppUserVM> users = _userService.TGetList().Select(x => new AdminAppUserVM

            {
                ID = x.Id,
                Name = x.Name,
                Surname = x.Surname,
                PhoneNo = x.PhoneNumber,
                Gender = x.Gender,
                UserName = x.UserName,
                Email = x.Email


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

            var user = _userService.TFind(id);

            if (user != null)
            {
                _userService.TDelete(user);
                TempData["SuccessMessage"] = "Islem basariyla gerceklesmistir.";
                return Redirect("/Admin/User/ListUsers");

            }
            ModelState.AddModelError("User", "Kullanıcı Silinemedi.");
            return View();
        }
        public IActionResult GetReservationHistory(int id)
        {
            List<AdminReservationVM> values = _rezervationService.getReservationsWithOthers().Where(x => x.AppUserID == id).Select(x => new AdminReservationVM
            {
                ID = x.ID,
                DestinationID = x.DestinationID,
                DestinationName = x.Destination.City,
                Description = x.Description,
                AppUserName = x.AppUser.Name,
                AppUserSurName = x.AppUser.Surname,
                RezervasyonDurumu = x.RezervasyonDurumu,
                CreatedDate = x.CreatedDate

            }).ToList();
            return View(values);
        }
        public IActionResult GetCommentHistory(int id)
        {
            var comments = _commentService.TGetCommentsWithDestinations().Where(x => x.AppUserID == id).Select(x => new AdminCommentVM
            {
                ID = x.ID,
                CommentContent = x.CommentContent,
                CommentReply = x.CommentReply,
                CommentUser = x.CommentUser,
                Status = x.Status.ToString(),
                DestinationID = x.DestinationID,
                DestinationName = x.Destination.City,
                CreatedDate = x.CreatedDate.ToString(),
                AppUserName = x.AppUser.Name,
                AppUserSurname = x.AppUser.Surname


            }).ToList();

            return View(comments);
        }
    }
}
