using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TraversalCoreProject.Areas.Member.Models
{
    public class MemberReservationListPageVM
    {
        public List<MemberReservationVM> Reservations { get; set; }

        public MemberUserVM User { get; set; }

    }
}
