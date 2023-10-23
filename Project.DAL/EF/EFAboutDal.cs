using Project.DAL.Abstract;
using Project.DAL.Concrete;
using Project.DAL.Repository;
using Project.ENTITIES.Concrete;

namespace Project.DAL.EF
{
    public class EFAboutDal : GenericRepository<About>, IAboutDal
    {
        public EFAboutDal(Context db) : base(db)
        {

        }



    }
}
