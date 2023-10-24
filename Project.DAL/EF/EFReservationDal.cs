using Microsoft.EntityFrameworkCore;
using Project.DAL.Abstract;
using Project.DAL.Context;
using Project.DAL.Repository;
using Project.ENTITIES.Concrete;
using System.Collections.Generic;
using System.Linq;

namespace Project.DAL.EF
{
    public class EFReservationDal : GenericRepository<Reservation>, IReservationDal
    {
        public EFReservationDal(MyContext db) : base(db)
        {

        }
        public List<Reservation> getReservationsWithOthers()
        {
            using (var context = new MyContext())
            {
                return context.Reservations.Include(x => x.AppUser).Include(x => x.Destination).ToList();
            }

        }



    }
}
