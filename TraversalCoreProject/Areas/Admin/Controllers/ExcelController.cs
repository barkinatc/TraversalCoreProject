using Microsoft.AspNetCore.Mvc;
using Project.Business.Abstract;

namespace TraversalCoreProject.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class ExcelController : Controller
    {
        private readonly IDestinationService _destinationService;
        private readonly IReservationService _reservationService;

        public ExcelController(IDestinationService destinationService, IReservationService reservationService)
        {
            _destinationService = destinationService;
            _reservationService = reservationService;
        }


        public IActionResult DownloadDestinationListAsExcel()
        {
            //List<AdminDestinationVM> destinations = _destinationService.TGetList().Select(x => new AdminDestinationVM
            //{
            //    City = x.City,
            //    Capacity = x.Capacity,
            //    DayNight = x.DayNight,
            //    Price = x.Price
            //}).ToList();

            var fileContents = _destinationService.GetDestinationsReportAsExcel();
            //ExcelPackage excel = new ExcelPackage();
            //var worksheet = excel.Workbook.Worksheets.Add("Tur Rotaları Excel Dosyası");


            //worksheet.Cells[1, 1].Value = "Şehir";
            //worksheet.Cells[1, 2].Value = "Kapasite";
            //worksheet.Cells[1, 3].Value = "Gün/Gece";
            //worksheet.Cells[1, 4].Value = "Fiyat";

            //int row = 2;
            //foreach (var item in destinations)
            //{
            //    worksheet.Cells[row, 1].Value = item.City;
            //    worksheet.Cells[row, 2].Value = item.Capacity;
            //    worksheet.Cells[row, 3].Value = item.DayNight;
            //    worksheet.Cells[row, 4].Value = item.Price;
            //    row++;
            //}
            //worksheet.Cells.AutoFitColumns();
            //var fileContents = excel.GetAsByteArray();
            return File(
       fileContents: fileContents,
       contentType: "application/vnd.openxmlformats-officedocument.spreadsheetml.sheet",
       fileDownloadName: "TurRotaları.xlsx"
   );
        }

        public IActionResult DownloadReservationListAsExcel()
        {
            //List<AdminReservationVM> reservations = _reservationService.getReservationsWithOthers().Where(x => x.RezervasyonDurumu != Project.ENTITIES.Enums.ReservationEnums.GeçmişRezervasyon).Select(x => new AdminReservationVM
            //{
            //    DestinationName = x.Destination.City,
            //    CreatedDate = x.CreatedDate,
            //    AppUserName = x.AppUser.Name,
            //    AppUserSurName = x.AppUser.Surname,
            //    RezervasyonDurumu = x.RezervasyonDurumu,
            //    PersonCount = x.PersonCount
            //}).ToList();
            //ExcelPackage excel = new ExcelPackage();
            //var worksheet = excel.Workbook.Worksheets.Add("Aktif Rezervasyon Excel Dosyası");

            //worksheet.Cells[1, 1].Value = "Şehir";
            //worksheet.Cells[1, 2].Value = "Kapasite";
            //worksheet.Cells[1, 3].Value = "Rezervasyon Sahibi";
            //worksheet.Cells[1, 4].Value = "Rezervasyon Durumu";
            //worksheet.Cells[1, 5].Value = "Rezervasyon Tarihi";
            //worksheet.Cells[1, 6].Value = "Kaç kişi";

            //int row = 2;
            //foreach (var item in reservations)
            //{
            //    worksheet.Cells[row, 1].Value = item.DestinationName;
            //    worksheet.Cells[row, 2].Value = item.PersonCount;
            //    worksheet.Cells[row, 3].Value = $"{item.AppUserName} {item.AppUserSurName}";
            //    worksheet.Cells[row, 4].Value = item.RezervasyonDurumu;
            //    worksheet.Cells[row, 5].Value = item.CreatedDate;
            //    worksheet.Cells[row, 6].Value = item.PersonCount;
            //    row++;
            //}
            //worksheet.Cells.AutoFitColumns();
            var fileContents = _reservationService.GetReservationsReportAsExcel();
            return File(
       fileContents: fileContents,
       contentType: "application/vnd.openxmlformats-officedocument.spreadsheetml.sheet",
       fileDownloadName: "AktifVeOnayBekleyenRezervasyonlar.xlsx");

        }
    }
}
