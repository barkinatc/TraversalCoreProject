using Project.DAL.Abstract;
using Project.DAL.Context;
using Project.DAL.Repository;
using Project.ENTITIES.Concrete;

namespace Project.DAL.EF
{
    public class EFFeatureDal : GenericRepository<Features>, IFeatureDal
    {
        public EFFeatureDal(MyContext db) : base(db)
        {

        }
    }
}
