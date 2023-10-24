using Project.DAL.Abstract;
using Project.DAL.Context;
using Project.DAL.Repository;
using Project.ENTITIES.Concrete;

namespace Project.DAL.EF
{
    public class EFAppUserDal : GenericRepository<AppUser>, IAppUserDal
    {
        public EFAppUserDal(MyContext db) : base(db)
        {

        }
    }
}
