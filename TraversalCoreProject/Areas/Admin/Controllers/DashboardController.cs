﻿using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Project.Business.Abstract;
using Project.Business.Concrete;
using Project.ENTITIES.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TraversalCoreProject.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class DashboardController : Controller
    {
        private readonly IDestinationService _destinationService;
        private readonly IGuideService _guideService;
        private readonly IReservationService _reservationService;
       // private readonly UserManager<AppUser> _userManager;
        private readonly IAppUserService _userService;


        public DashboardController(IGuideService guideService, IReservationService reservationService, IDestinationService destinationService, IAppUserService userService)
        {
            _guideService = guideService;
            _userService = userService;
            _reservationService = reservationService;
            _destinationService = destinationService;
        }

        public IActionResult Dashboard()
        {
            var destinations = _destinationService.TGetList();
            var guides = _guideService.TGetList();
            var reservations = _reservationService.TGetList();
            var users = _userService.TGetList();

            ViewBag.r = reservations.Count();
            ViewBag.u = users.Count();
            ViewBag.g = guides.Count();
            ViewBag.d = destinations.Count();
            return View();
        }
      
    }
}
