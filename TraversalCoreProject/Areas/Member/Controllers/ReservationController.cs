using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Project.Business.Concrete;
using Project.DAL.EF;
using Project.ENTITIES.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TraversalCoreProject.ViewModels;

namespace TraversalCoreProject.Areas.Member.Controllers
{
    [Area("Member")]
  

    public class ReservationController : Controller
    {
       readonly DestinationManager  destinationManager = new DestinationManager(new EFDestinationDal());
      readonly  ReservationManager reservationManager = new ReservationManager(new EFReservationDal());
       
       
        private readonly UserManager<AppUser> _userManager;

        public ReservationController(UserManager<AppUser> userManager)
        {
            this._userManager = userManager;
            
        }

    
        public IActionResult ListReservations()
        {
            var values = _userManager.FindByNameAsync(User.Identity.Name);
            var listReservations = reservationManager.TWhere(x => x.AppUserID == values.Result.Id);
            


            return View(listReservations);
        }
     
        [HttpGet]
        public IActionResult NewReservation()
        {
            var values = (from x in destinationManager.TGetList()
                          select new SelectListItem
                          {
                              Text = x.City,
                              Value = x.ID.ToString()
                          }
                          ).ToList();

            ViewBag.v = values;
            return View();
        }
        [HttpPost]
        public IActionResult NewReservation(Reservation p)
        {
            var values = _userManager.FindByNameAsync(User.Identity.Name);

            p.AppUserID = values.Result.Id;
            reservationManager.TAdd(p);
            return View();
        }
    }
}
