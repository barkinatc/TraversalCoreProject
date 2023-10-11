﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.ENTITIES.Concrete
{
  public  class Reservation:BaseEntity
    {
        public string PersonCount { get; set; }
        public string Destination { get; set; }
        public string Description { get; set; }
        public int AppUserID { get; set; }
        //Relational prop
        public AppUser AppUser { get; set; }
    }
}