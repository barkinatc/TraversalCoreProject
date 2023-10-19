using Microsoft.EntityFrameworkCore;
using Project.DAL.Abstract;
using Project.DAL.Concrete;
using Project.DAL.Repository;
using Project.ENTITIES.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.DAL.EF
{
    public class EFReservationDal : GenericRepository<Reservation>, IReservationDal
    {
        public List<Reservation> getReservationsWithOthers()
        {
            using (var context = new Context())
            {
                return context.Reservations.Include(x => x.AppUser).Include(x => x.Destination).ToList();
            }

        }
    }
}
