﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.ENTITIES.Concrete
{
  public  class Guide:BaseEntity
    {
        public string Name { get; set; }
        public string Description { get; set; }

        public string Image { get; set; }
        public string TwitterUrl { get; set; }
        public string InstagramUrl { get; set; }

    }
}
