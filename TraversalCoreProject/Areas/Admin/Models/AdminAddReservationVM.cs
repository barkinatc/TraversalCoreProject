using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TraversalCoreProject.Areas.Admin.Models
{
    public class AdminAddReservationVM
    {
        public List<AdminDestinationVM> Destinations { get; set; }
        public List<AdminAppUserVM> AppUsers { get; set; }

        public AdminReservationVM Reservation { get; set; }

    }
}
