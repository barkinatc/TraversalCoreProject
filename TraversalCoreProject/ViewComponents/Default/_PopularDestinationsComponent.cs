using Microsoft.AspNetCore.Mvc;
using Project.Business.Abstract;
using System.Collections.Generic;
using System.Linq;
using TraversalCoreProject.ViewModels;

namespace TraversalCoreProject.ViewComponents.Default
{
    public class _PopularDestinationsComponent : ViewComponent
    {
        //  readonly DestinationManager destinationManager = new DestinationManager(new EFDestinationDal());

        private readonly IDestinationService _destinationService;

        public _PopularDestinationsComponent(IDestinationService destinationService)
        {
            _destinationService = destinationService;
        }

        public IViewComponentResult Invoke()
        {
            List<DestinationVM> destinations =
_destinationService.TGetList().Select(x => new DestinationVM

{
    ID = x.ID,
    Image = x.Image,
    City = x.City,
    Description = x.Description
,
    Price = x.Price,
    DayNight = x.DayNight
}).ToList();
            return View(destinations);
        }
    }
}
