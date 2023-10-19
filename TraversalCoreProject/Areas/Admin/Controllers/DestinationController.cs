using Microsoft.AspNetCore.Mvc;
using Project.Business.Abstract;
using Project.Business.Concrete;
using Project.DAL.EF;
using Project.ENTITIES.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TraversalCoreProject.Areas.Admin.Models;

namespace TraversalCoreProject.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class DestinationController : Controller
    {
        private readonly IDestinationService _destinationService;

        public DestinationController(IDestinationService destinationService)
        {
            _destinationService = destinationService;
        }

        public IActionResult ListDestinations()
        {
            AdminDestinationPageListVM listVM = new AdminDestinationPageListVM();

            List<AdminDestinationVM> destinations = _destinationService.TWhere(x => x.Status != Project.ENTITIES.Enums.DataStatus.Deleted).Select(x => new AdminDestinationVM
            {
                ID = x.ID,
                City = x.City,
                DayNight = x.DayNight,
                Capacity = x.Capacity,
                CreatedDate = x.CreatedDate.ToString(),
                Description = x.Description,
                Price = x.Price,
                Status = x.Status.ToString()


            }).ToList();
            listVM.Destinations = destinations;
            return View(listVM);
            //var values = _destinationManager.TGetList();

            //return View(values);
        }
        [HttpGet]
        public IActionResult AddDestination()
        {
            return View();
        }

        [HttpPost]
        public IActionResult AddDestination(AdminDestinationVM destinationVM)
        {
            if (ModelState.IsValid)
            {
                Destination destination = new Destination
                {
                    City = destinationVM.City,
                    Price = destinationVM.Price,
                    Description = destinationVM.Description,
                    DayNight = destinationVM.DayNight,
                    Capacity = destinationVM.Capacity,

                };
                _destinationService.TAdd(destination);
                //image

                return Redirect("/Admin/Destination/ListDestinations");
            }


            //_destinationManager.TAdd(p);

            return Redirect("/Admin/Destination/ListDestinations");
           
        }
        [HttpGet]
        public IActionResult UpdateDestination(int id)
        {
            var destination = _destinationService.TWhere(x => x.ID == id).Select(x => new AdminDestinationVM
            {
                ID = x.ID,
                City = x.City,
                DayNight = x.DayNight,
                Description = x.Description,
                Price = x.Price
            }).FirstOrDefault();
            return View(destination);
        }
        [HttpPost]
        public IActionResult UpdateDestination(AdminDestinationVM destinationVM)
        {

            Destination toBeUpdated = _destinationService.TFind(destinationVM.ID);
            toBeUpdated.ID = destinationVM.ID;
            toBeUpdated.City = destinationVM.City;
            toBeUpdated.DayNight = destinationVM.DayNight;
            toBeUpdated.Description = destinationVM.Description;
            toBeUpdated.Price = destinationVM.Price;

            _destinationService.TUpdate(toBeUpdated);
            return Redirect("/Admin/Destination/ListDestinations");
        }

        public IActionResult DeleteDestination(int id )
        {
            _destinationService.TDestroy(_destinationService.TFind(id));
            return Redirect("/Admin/Destination/ListDestinations");
        }
    }
}
