using OfficeOpenXml;
using Project.Business.Abstract;
using Project.DAL.Abstract;
using Project.ENTITIES.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Project.Business.Concrete
{
    public class ReservationManager : IReservationService
    {
        IReservationDal _reservationDal;

        public ReservationManager(IReservationDal reservationDal)
        {
            _reservationDal = reservationDal;
        }

        public void acceptReservaiton(int id)
        {
            var reservation = _reservationDal.Find(id);
            reservation.RezervasyonDurumu = ENTITIES.Enums.ReservationEnums.AktifRezervasyon;
            _reservationDal.Update(reservation);
        }

        public void cancelReservation(int id)
        {
            var reservation = _reservationDal.Find(id);
            reservation.RezervasyonDurumu = ENTITIES.Enums.ReservationEnums.GeçmişRezervasyon;
            _reservationDal.Update(reservation);
           

        }

        public byte[] GetReservationsReportAsExcel()
        {
            var reservations = _reservationDal.getReservationsWithOthers().Where(x => x.RezervasyonDurumu != Project.ENTITIES.Enums.ReservationEnums.GeçmişRezervasyon);
            ExcelPackage.LicenseContext = LicenseContext.NonCommercial;
            ExcelPackage excel = new ExcelPackage();
            var worksheet = excel.Workbook.Worksheets.Add("Aktif Rezervasyon Excel Dosyası");

            worksheet.Cells[1, 1].Value = "Şehir";
            worksheet.Cells[1, 2].Value = "Kapasite";
            worksheet.Cells[1, 3].Value = "Rezervasyon Sahibi";
            worksheet.Cells[1, 4].Value = "Rezervasyon Durumu";
            worksheet.Cells[1, 5].Value = "Rezervasyon Tarihi";
            worksheet.Cells[1, 6].Value = "Kaç kişi";

            int row = 2;
            foreach (var item in reservations)
            {
                worksheet.Cells[row, 1].Value = item.Destination.City;
                worksheet.Cells[row, 2].Value = item.PersonCount;
                worksheet.Cells[row, 3].Value = $"{item.AppUser.Name} {item.AppUser.Surname}";
                worksheet.Cells[row, 4].Value = item.RezervasyonDurumu;
                worksheet.Cells[row, 5].Value = item.CreatedDate.Date;
                worksheet.Cells[row, 6].Value = item.PersonCount;
                row++;
            }
            worksheet.Cells.AutoFitColumns();
            return excel.GetAsByteArray();
        }

        public List<Reservation> getReservationsWithOthers()
        {
            return _reservationDal.getReservationsWithOthers();
        }

        public void TAdd(Reservation t)
        {
            _reservationDal.Add(t);
            
            
        }

        public bool TAny(Expression<Func<Reservation, bool>> exp)
        {
            return _reservationDal.Any(exp);
        }

        public void TDelete(Reservation t)
        {
            
            _reservationDal.Delete(t);

        }

        public void TDestroy(Reservation t)
        {
            _reservationDal.Destroy(t);

        }

        public Reservation TFind(int id)
        {
            return _reservationDal.Find(id);

        }

        public Reservation TFirstOrDefault(Expression<Func<Reservation, bool>> exp)
        {
            return _reservationDal.FirstOrDefault(exp);

        }

        public List<Reservation> TGetActives()
        {
            return _reservationDal.GetActives();

        }

   

        public List<Reservation> TGetFirstDatas(int number)
        {
            return _reservationDal.GetFirstDatas(number);

        }

        public List<Reservation> TGetLastDatas(int number)
        {
            return _reservationDal.GetLastDatas(number);

        }

        public List<Reservation> TGetList()
        {
            return _reservationDal.GetAll();

        }

        public List<Reservation> TGetPasives()
        {
            return _reservationDal.GetPassives();

        }

        public List<Reservation> TGetUpdatedes()
        {
            return _reservationDal.GetUpdateds();

        }

        public IQueryable<Reservation> TInclude(Expression<Func<Reservation, object>> includeProperty)
        {
            return _reservationDal.Include(includeProperty);
        }

        public IQueryable<X> TSelect<X>(Expression<Func<Reservation, X>> exp)
        {
            return _reservationDal.Select(exp);

        }

        public void TUpdate(Reservation t)
        {
            _reservationDal.Update(t);

        }

        public List<Reservation> TWhere(Expression<Func<Reservation, bool>> exp)
        {
            return _reservationDal.Where(exp);

        }
    }
}
