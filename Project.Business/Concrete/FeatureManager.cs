using Project.Business.Abstract;
using Project.DAL.Abstract;
using Project.ENTITIES.Concrete;

namespace Project.Business.Concrete
{
    public class FeatureManager : BaseManager<Features>, IFeatureService
    {
        IFeatureDal _featuresDal;

        public FeatureManager(IFeatureDal featuresDal) : base(featuresDal)
        {
            _featuresDal = featuresDal;
        }


    }
}
