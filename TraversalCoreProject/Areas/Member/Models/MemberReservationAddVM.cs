using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TraversalCoreProject.Areas.Member.Models
{
    public class MemberReservationAddVM
    {
        public List<MemberDestinationVM> Destinations { get; set; }
        public MemberReservationVM Reservation { get; set; }

        public MemberUserVM User { get; set; }

    }
}
