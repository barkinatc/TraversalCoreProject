using OfficeOpenXml;
using Project.Business.Abstract;
using Project.DAL.Abstract;
using Project.ENTITIES.Concrete;

namespace Project.Business.Concrete
{
    public class DestinationManager : BaseManager<Destination>, IDestinationService
    {
        IDestinationDal _destinationDal;
        public DestinationManager(IDestinationDal destinationDal) : base(destinationDal)
        {
            _destinationDal = destinationDal;
        }

        public byte[] GetDestinationsReportAsExcel()
        {
            var destinations = _destinationDal.GetAll();
            ExcelPackage.LicenseContext = LicenseContext.NonCommercial;
            ExcelPackage excel = new ExcelPackage();
            var worksheet = excel.Workbook.Worksheets.Add("Tur Rotaları Excel Dosyası");

            worksheet.Cells[1, 1].Value = "Şehir";
            worksheet.Cells[1, 2].Value = "Kapasite";
            worksheet.Cells[1, 3].Value = "Gün/Gece";
            worksheet.Cells[1, 4].Value = "Fiyat";

            int row = 2;
            foreach (var item in destinations)
            {
                worksheet.Cells[row, 1].Value = item.City;
                worksheet.Cells[row, 2].Value = item.Capacity;
                worksheet.Cells[row, 3].Value = item.DayNight;
                worksheet.Cells[row, 4].Value = item.Price;
                row++;
            }
            worksheet.Cells.AutoFitColumns();

            return excel.GetAsByteArray();
        }


    }
}
