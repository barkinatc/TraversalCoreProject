﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

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
        public string RezervasyonDurumu { get; set; }
        public string CreatedDate { get; set; }
        public string Status { get; set; }
    }
}
