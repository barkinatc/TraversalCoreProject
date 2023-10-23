using Project.Business.Abstract;
using Project.DAL.Abstract;
using Project.ENTITIES.Concrete;

namespace Project.Business.Concrete
{
    public class AboutManager : BaseManager<About>, IAboutService
    {
        IAboutDal _aboutDal;
        public AboutManager(IAboutDal aboutDal) : base(aboutDal)
        {
            _aboutDal = aboutDal;
        }
    }
}
