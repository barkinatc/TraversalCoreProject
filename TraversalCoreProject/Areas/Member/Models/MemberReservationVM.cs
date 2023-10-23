using System;

namespace TraversalCoreProject.Areas.Member.Models
{
    public class MemberReservationVM
    {
        public int ID { get; set; }

        public int AppUserID { get; set; }
        public string PersonCount { get; set; }
        public string DestinationName { get; set; }
        public int DestinationID { get; set; }
        public string Description { get; set; }
        public DateTime CreatedDate { get; set; }
        public string Status { get; set; }
        public string RezervasyonDurumu { get; set; }

    }
}
