using Project.ENTITIES.Concrete;
using System.Collections.Generic;

namespace Project.Business.Abstract
{
    public interface IReservationService : IGenericService<Reservation>
    {
        List<Reservation> getReservationsWithOthers();
        byte[] GetReservationsReportAsExcel();
        public void cancelReservation(int id);
        public void acceptReservaiton(int id);


    }
}
