using Project.Business.Abstract;
using Project.DAL.Abstract;
using Project.ENTITIES.Concrete;

namespace Project.Business.Concrete
{
    public class SubAboutManager : BaseManager<SubAbout>, ISubAboutService
    {
        ISubAboutDal _subAboutDal;

        public SubAboutManager(ISubAboutDal subAboutDal) : base(subAboutDal)
        {
            _subAboutDal = subAboutDal;
        }


    }
}
