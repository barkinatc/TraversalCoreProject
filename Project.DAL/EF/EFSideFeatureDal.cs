using Project.DAL.Abstract;
using Project.DAL.Context;
using Project.DAL.Repository;
using Project.ENTITIES.Concrete;

namespace Project.DAL.EF
{
    public class EFSideFeatureDal : GenericRepository<SideFeatures>, ISideFeatureDal
    {
        public EFSideFeatureDal(MyContext db) : base(db)
        {

        }
    }
}
