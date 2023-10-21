using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Project.Business.Abstract;
using Project.Business.Concrete;
using Project.DAL.EF;
using Project.ENTITIES.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TraversalCoreProject.Areas.Member.Models;
using TraversalCoreProject.ViewModels;

namespace TraversalCoreProject.Areas.Member.Controllers
{
    [Area("Member")]
  

    public class ReservationController : Controller
    {
        private readonly IDestinationService _destinationService;
        private readonly IReservationService _reservationService;
        private readonly IAppUserService _userService;
        private readonly UserManager<AppUser> _userManager;

        public ReservationController(IDestinationService destinationService, IReservationService reservationService, IAppUserService userService, UserManager<AppUser> userManager)
        {
            _destinationService = destinationService;
            _reservationService = reservationService;
            _userService = userService;
            _userManager = userManager;
        }


        public async Task<IActionResult> ListReservations()
        {
            var user = await _userManager.FindByNameAsync(User.Identity.Name);
            var listReservations = _reservationService
                           .TGetList()
                           //.Include(r => r.Destination) 
                           .Where(x => x.AppUserID == user.Id)
                           .Select(x => new MemberReservationVM
                           {
                               ID = x.ID,
                               DestinationID = x.DestinationID,
                               DestinationName = x.Destination.City,
                               CreatedDate = x.CreatedDate,
                               Status = x.Status.ToString(),
                               Description = x.Description,
                               PersonCount = x.PersonCount,
                               RezervasyonDurumu = x.RezervasyonDurumu.ToString()
                           }).ToList();



            return View(listReservations);
        }
     
        [HttpGet]
        public IActionResult NewReservation()
        {
            var values = (from x in _destinationService.TGetList()
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
        public IActionResult NewReservation(MemberReservationVM p)
        {
            var values = _userManager.FindByNameAsync(User.Identity.Name);

            Reservation reservation = new Reservation();
            reservation.DestinationID = p.DestinationID;
            //reservation.Destination = new Destination();
            //reservation.Destination.ID = p.DestinationID;
            reservation.AppUserID = p.AppUserID;
            reservation.PersonCount = p.PersonCount;
            reservation.CreatedDate = p.CreatedDate;
            reservation.Description = p.Description;
            _reservationService.TAdd(reservation);
            return Redirect("/Member/Reservation/ListReservations");
        }
    }
}
