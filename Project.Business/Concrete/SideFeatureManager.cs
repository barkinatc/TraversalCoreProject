using Project.Business.Abstract;
using Project.DAL.Abstract;
using Project.ENTITIES.Concrete;

namespace Project.Business.Concrete
{
    public class SideFeatureManager : BaseManager<SideFeatures>, ISideFeatureService
    {
        ISideFeatureDal _sideFeatureDal;

        public SideFeatureManager(ISideFeatureDal sideFeatureDal) : base(sideFeatureDal)
        {
            _sideFeatureDal = sideFeatureDal;
        }


    }
}
