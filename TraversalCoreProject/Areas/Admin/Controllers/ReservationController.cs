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

        public ReservationController(IReservationService reservationService, IDestinationService destinationService, UserManager<AppUser> userManager)
        {
            _reservationService = reservationService;
            _userManager = userManager;
            _destinationService = destinationService;
           
            _destinations = _destinationService.TGetList().Select(x => new AdminDestinationVM
            {

                ID = x.ID,
                City = x.City

            }).ToList();
        }
        List<AdminDestinationVM> _destinations; 
        
        public IActionResult ListReservations()
        {
            var reservationList = _reservationService.getReservationsWithOthers();
            List<AdminReservationVM> reservations = reservationList.Select(x => new AdminReservationVM
            {
                ID = x.ID,
                AppUserName = $"{x.AppUser.Name} {x.AppUser.Surname}",
                CreatedDate = x.CreatedDate,
                PersonCount = x.PersonCount,
                DestinationName = x.Destination.City,
                Description = x.Description,
                RezervasyonDurumu = x.RezervasyonDurumu,
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
            AdminAddReservationVM addReservationVM = new AdminAddReservationVM
            {
                AppUsers = _userManager.Users.Select(x => new AdminAppUserVM
                {
                    ID = x.Id,
                    Name = x.Name,
                    Surname = x.Surname
                }).ToList(),
                Destinations =_destinations


            };



            return View(addReservationVM);
        }
        [HttpPost]
        public IActionResult AddReservation(AdminAddReservationVM p)
        {
            if (ModelState.IsValid)
            {


                Reservation reservation = new Reservation();


                reservation.AppUserID = p.Reservation.AppUserID;
                reservation.CreatedDate = p.Reservation.CreatedDate;
                reservation.Description = p.Reservation.Description;
                reservation.DestinationID = p.Reservation.DestinationID;
                reservation.PersonCount = p.Reservation.PersonCount;





                _reservationService.TAdd(reservation);

                return Redirect("/Admin/Reservation/ListReservations");
            }
            return View();
        }
        public IActionResult DeleteReservation(int id)
        {
            _reservationService.cancelReservation(id);

            _reservationService.TDelete(_reservationService.TFind(id));




            return Redirect("/Admin/Reservation/ListReservations");
        }

        [HttpGet]

        public IActionResult UpdateReservation(int id)
        {
            AdminUpdateReservationVM updateVM = new AdminUpdateReservationVM 
            {
                Destinations = _destinations,
                Reservation = _reservationService.TWhere(x => x.ID == id).Select(x => new AdminReservationVM
                {

                    ID = x.ID,
                    Description = x.Description,
                    DestinationID = x.DestinationID,
                    DestinationName = x.DestinationName,
                    PersonCount = x.PersonCount,
                    RezervasyonDurumu =x.RezervasyonDurumu
                    
                  


                }).FirstOrDefault()
            };
           
            return View(updateVM);
        }
        [HttpPost]
        public IActionResult UpdateReservation(AdminUpdateReservationVM p)
        {
            Reservation toBeUpdated = _reservationService.TFind(p.Reservation.ID);
            toBeUpdated.ID = p.Reservation.ID;
            toBeUpdated.RezervasyonDurumu = p.RezervasyonDurumu;
            toBeUpdated.PersonCount = p.Reservation.PersonCount;
            toBeUpdated.DestinationID = p.Reservation.DestinationID;
            toBeUpdated.DestinationName = p.Reservation.DestinationName;
            toBeUpdated.CreatedDate = p.Reservation.CreatedDate;
            toBeUpdated.Description = p.Reservation.Description;
            _reservationService.TUpdate(toBeUpdated);

            return Redirect("/Admin/Reservation/ListReservations");
        }
        
    }
}
