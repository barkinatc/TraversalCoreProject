using Project.ENTITIES.Enums;
using System;

namespace TraversalCoreProject.Areas.Admin.Models
{
    public class AdminReservationVM
    {
        public int ID { get; set; }

        public string PersonCount { get; set; }
        public string DestinationName { get; set; }
        public int DestinationID { get; set; }
        public string Description { get; set; }
        public int AppUserID { get; set; }

        public string AppUserName { get; set; }
        public string AppUserSurName { get; set; }

        public ReservationEnums RezervasyonDurumu { get; set; }
        public DateTime CreatedDate { get; set; }
        public string Status { get; set; }
        public string PhoneNo { get; set; }

    }
}
