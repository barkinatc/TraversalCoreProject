using Microsoft.AspNetCore.Mvc;
using Project.Business.Abstract;
using System.Collections.Generic;
using System.Linq;
using Project.VM.ViewModels;

namespace TraversalCoreProject.Controllers
{

    public class PdfController : Controller
    {
        private readonly IReservationService _reservationService;
        private readonly IDestinationService _destinationService;

        public PdfController(IReservationService reservationService, IDestinationService destinationService)
        {
            _reservationService = reservationService;
            _destinationService = destinationService;
        }

        public IActionResult DownloadReservationListAsPdf()
        {
            List<ReservationVM> reservations = _reservationService.getReservationsWithOthers().Where(x => x.RezervasyonDurumu != Project.ENTITIES.Enums.ReservationEnums.GeçmişRezervasyon).Select(x => new ReservationVM
            {
                DestinationName = x.Destination.City,
                CreatedDate = x.CreatedDate.ToString(),
                AppUserName = x.AppUser.Name,
                AppUserSurName = x.AppUser.Surname,
                RezervasyonDurumu = x.RezervasyonDurumu.ToString(),
                PersonCount = x.PersonCount
            }).ToList();
            //var stream = new MemoryStream();
            //var writer = new PdfWriter(stream);
            //var pdf = new PdfDocument(writer);
            //var document = new Document(pdf, PageSize.A4.Rotate());
            //document.SetMargins(20, 20, 20, 20);

            return View();
        }
    }
}
