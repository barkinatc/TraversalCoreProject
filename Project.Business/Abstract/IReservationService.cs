using Project.ENTITIES.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.Business.Abstract
{
    public interface IReservationService : IGenericService<Reservation>
    {
        List<Reservation> getReservationsWithOthers();
        byte[] GetReservationsReportAsExcel();
        public void cancelReservation(int id );
       public void acceptReservaiton(int id );


    }
}
