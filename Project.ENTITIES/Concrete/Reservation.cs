using Project.ENTITIES.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.ENTITIES.Concrete
{
  public  class Reservation:BaseEntity
    {
        public string PersonCount { get; set; }
        public string DestinationName { get; set; }
        public int DestinationID { get; set; }
        public string Description { get; set; }
        public int AppUserID { get; set; }
        public ReservationEnums RezervasyonDurumu { get; set; }
        //Relational prop
        public AppUser AppUser { get; set; }
        public  Destination  Destination { get; set; }

        public Reservation()
        {
            RezervasyonDurumu = ReservationEnums.OnayBekliyor;
        }

    }
}
