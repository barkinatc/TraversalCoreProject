using Project.DAL.Abstract;
using Project.DAL.Concrete;
using Project.DAL.Repository;
using Project.ENTITIES.Concrete;

namespace Project.DAL.EF
{
    public class EFGuideDal : GenericRepository<Guide>, IGuideDal
    {
        public EFGuideDal(Context db) : base(db)
        {

        }
    }
}
