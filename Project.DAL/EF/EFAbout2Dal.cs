﻿using Project.DAL.Abstract;
using Project.DAL.Repository;
using Project.ENTITIES.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.DAL.EF
{
   public class EFAbout2Dal : GenericRepository<About2>, IAbout2Dal
    {
    }
}
