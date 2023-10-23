using Microsoft.AspNetCore.Mvc;
using Project.Business.Abstract;
using System.Collections.Generic;
using System.Linq;
using TraversalCoreProject.ViewModels;

namespace TraversalCoreProject.Controllers
{
    public class DestinationController : Controller
    {
        // DestinationManager destinationManager = new DestinationManager(new EFDestinationDal());
        private readonly IDestinationService _destinationService;

        public DestinationController(IDestinationService destinationService)
        {
            _destinationService = destinationService;
        }

        public IActionResult Index()
        {
            List<DestinationVM> destinations = _destinationService.TGetList().Select(x => new DestinationVM
            {
                ID = x.ID,
                City = x.City,
                Description = x.Description,
                Image = x.Image,
                Price = x.Price

            }).ToList();
            //var values = destinationManager.TGetList();
            return View(destinations);
        }
        [HttpGet]
        public IActionResult DestinationDetails(int id)
        {
            DestinationVM destination = _destinationService.TGetList().Where(x => x.ID == id).Select(x => new DestinationVM
            {
                ID = x.ID,
                City = x.City,
                Description = x.Description,
                Image = x.Image,
                Price = x.Price,
                Details1 = x.Details1,
                Details2 = x.Details2

            }).FirstOrDefault();
            ViewBag.i = id;
            // Destination value = destinationManager.TFind(id);
            return View(destination);
        }
        [HttpPost]

        public IActionResult DestinationDetails(DestinationVM p)
        {
            return View();
        }
    }
}
