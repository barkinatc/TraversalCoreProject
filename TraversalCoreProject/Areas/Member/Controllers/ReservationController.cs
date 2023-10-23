using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Project.Business.Abstract;
using Project.ENTITIES.Concrete;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TraversalCoreProject.Areas.Member.Models;


namespace TraversalCoreProject.Areas.Member.Controllers
{
    [Area("Member")]


    public class ReservationController : Controller
    {
        private readonly IDestinationService _destinationService;
        private readonly IReservationService _reservationService;
        private readonly IAppUserService _userService;


        public ReservationController(IDestinationService destinationService, IReservationService reservationService, IAppUserService userService, UserManager<AppUser> userManager)
        {
            _destinationService = destinationService;
            _reservationService = reservationService;
            _userService = userService;

        }


        public async Task<IActionResult> ListReservations()
        {

            var user = await _userService.GetCurrentUserAsync(User);
            var listReservations = _reservationService
                           .getReservationsWithOthers()
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


            List<MemberDestinationVM> destinations = _destinationService.TGetList().Select(x => new MemberDestinationVM
            {
                ID = x.ID,
                City = x.City
            }).ToList();

            MemberReservationAddVM addVM = new MemberReservationAddVM

            {

                Destinations = destinations
            };


            return View(addVM);
        }
        [HttpPost]
        public async Task<IActionResult> NewReservation(MemberReservationAddVM p)
        {
            var user = await _userService.GetCurrentUserAsync(User);

            Reservation reservation = new Reservation();
            reservation.DestinationID = p.Reservation.DestinationID;
            //reservation.Destination = new Destination();
            //reservation.Destination.ID = p.DestinationID;
            reservation.AppUserID = user.Id;
            reservation.PersonCount = p.Reservation.PersonCount;
            reservation.CreatedDate = p.Reservation.CreatedDate;
            reservation.Description = p.Reservation.Description;
            _reservationService.TAdd(reservation);
            return Redirect("/Member/Reservation/ListReservations");
        }
    }
}
