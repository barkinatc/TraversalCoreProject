using Project.DAL.Abstract;
using Project.DAL.Context;
using Project.DAL.Repository;
using Project.ENTITIES.Concrete;

namespace Project.DAL.EF
{
    public class EFAboutDal : GenericRepository<About>, IAboutDal
    {
        public EFAboutDal(MyContext db) : base(db)
        {

        }



    }
}
