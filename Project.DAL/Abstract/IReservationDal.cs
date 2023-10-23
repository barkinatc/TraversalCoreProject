using Project.ENTITIES.Concrete;
using System.Collections.Generic;

namespace Project.DAL.Abstract
{
    public interface IReservationDal : IGenericDal<Reservation>
    {
        List<Reservation> getReservationsWithOthers();
    }
}
