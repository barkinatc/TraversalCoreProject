using System.Collections.Generic;

namespace TraversalCoreProject.Areas.Admin.Models
{
    public class AdminAddReservationVM
    {
        public List<AdminDestinationVM> Destinations { get; set; }
        public List<AdminAppUserVM> AppUsers { get; set; }


        public AdminReservationVM Reservation { get; set; }

    }
}
