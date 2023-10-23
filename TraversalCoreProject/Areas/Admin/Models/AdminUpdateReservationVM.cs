using Project.ENTITIES.Enums;
using System.Collections.Generic;

namespace TraversalCoreProject.Areas.Admin.Models
{
    public class AdminUpdateReservationVM
    {
        public List<AdminDestinationVM> Destinations { get; set; }
        public AdminReservationVM Reservation { get; set; }

        public ReservationEnums RezervasyonDurumu { get; set; }


    }
}
