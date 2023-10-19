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
