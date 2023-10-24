using Project.Business.Abstract;
using Project.DAL.Abstract;
using Project.ENTITIES.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.Business.Concrete
{
  public  class AnnouncementManager:BaseManager<Announcement>,IAnnouncementService
    {
        IAnnouncementDal _announcementDal;
        public AnnouncementManager(IAnnouncementDal announcementDal):base(announcementDal)
        {
            _announcementDal = announcementDal;
        }
    }
}
