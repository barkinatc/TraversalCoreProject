using Project.DAL.Abstract;
using Project.DAL.Context;
using Project.DAL.Repository;
using Project.ENTITIES.Concrete;

namespace Project.DAL.EF
{
    public class EFGuideDal : GenericRepository<Guide>, IGuideDal
    {
        public EFGuideDal(MyContext db) : base(db)
        {

        }
    }
}
