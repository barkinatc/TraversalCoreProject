using Project.Business.Abstract;
using Project.DAL.Abstract;
using Project.ENTITIES.Concrete;

namespace Project.Business.Concrete
{
    public class GuideManager : BaseManager<Guide>, IGuideService
    {

        IGuideDal _guideDal;

        public GuideManager(IGuideDal guideDal) : base(guideDal)
        {
            _guideDal = guideDal;
        }

        public void ActiveGuide(int id)
        {
            var guide = _guideDal.Find(id);
            guide.DeletedDate = null;
            guide.Status = ENTITIES.Enums.DataStatus.Inserted;

            _guideDal.Update(guide);

        }


    }
}
