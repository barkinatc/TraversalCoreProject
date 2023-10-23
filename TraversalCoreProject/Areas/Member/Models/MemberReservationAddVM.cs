using System.Collections.Generic;

namespace TraversalCoreProject.Areas.Member.Models
{
    public class MemberReservationAddVM
    {
        public List<MemberDestinationVM> Destinations { get; set; }
        public MemberReservationVM Reservation { get; set; }

        public MemberUserVM User { get; set; }

    }
}
