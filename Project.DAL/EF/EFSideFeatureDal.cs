using Project.DAL.Abstract;
using Project.DAL.Concrete;
using Project.DAL.Repository;
using Project.ENTITIES.Concrete;

namespace Project.DAL.EF
{
    public class EFSideFeatureDal : GenericRepository<SideFeatures>, ISideFeatureDal
    {
        public EFSideFeatureDal(Context db) : base(db)
        {

        }
    }
}
