using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
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
    public class ReservationController : Controller
    {
        private readonly IReservationService _reservationService;
        private readonly UserManager<AppUser> _userManager;
        private readonly IDestinationService _destinationService;

        public ReservationController(IReservationService reservationService,IDestinationService destinationService,UserManager<AppUser> userManager)
        {
            _reservationService = reservationService;
            _userManager = userManager;
            _destinationService = destinationService;


        }

        public IActionResult ListReservations()
        {
            var reservationList = _reservationService.getReservationsWithOthers();
            List<AdminReservationVM> reservations = reservationList.Select(x => new AdminReservationVM
            {
                ID = x.ID,
                AppUserName = $"{x.AppUser.Name} {x.AppUser.Surname}",
                CreatedDate = x.CreatedDate.ToString(),
                PersonCount = x.PersonCount,
                DestinationName = x.Destination.City,
                Description = x.Description,
                RezervasyonDurumu = x.RezervasyonDurumu.ToString(),
                Status = x.Status.ToString(),



            }).ToList();

            AdminReservationPageListVM listVM = new AdminReservationPageListVM 
            { 
                Reservations = reservations
            };

            return View(listVM);
        }
        [HttpGet]
        public IActionResult AddReservation()
        {
            //List<AdminAppUserVM> appUsers =  _userManager.Users.Select(x => new AdminAppUserVM
            //{
            //    ID = x.Id,
            //    Name = x.Name,
            //    Surname = x.Surname
            //}).ToList();

            List<AdminDestinationVM> destinations = _destinationService.TSelect(x => new AdminDestinationVM
            {
                ID = x.ID,
                City = x.City
            }).ToList();

           // ViewBag.users = appUsers;
            ViewBag.destinations = destinations;





            return View();
        }
        [HttpPost]
        public IActionResult AddReservation(AdminReservationVM p)
        {
            return View();
        }
    }
}
