using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TraversalCoreProject.ViewModels
{
    public class ReservationVM
    {
        public int ID { get; set; }
        public string PersonCount { get; set; }
        public string Destination { get; set; }
        public string Description { get; set; }
        public string ReservationDate { get; set; }

        public int AppUserID { get; set; }

    }
}
