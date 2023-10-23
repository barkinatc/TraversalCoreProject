using Project.Business.Abstract;
using Project.DAL.Abstract;
using Project.ENTITIES.Concrete;

namespace Project.Business.Concrete
{
    public class About2Manager : BaseManager<About2>, IAbout2Service
    {
        IAbout2Dal _about2Dal;



        public About2Manager(IAbout2Dal about2Dal) : base(about2Dal)
        {
            _about2Dal = about2Dal;
        }

    }
}
