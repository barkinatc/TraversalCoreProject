using Microsoft.AspNetCore.Authorization;
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
        DestinationManager destinationManager = new DestinationManager(new EFDestinationDal());
        ReservationManager reservationManager = new ReservationManager(new EFReservationDal());
        public IActionResult CurrentReservation()
        {
           
            return View();
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
            p.AppUserID = 3;
            reservationManager.TAdd(p);
            return View();
        }
    }
}
