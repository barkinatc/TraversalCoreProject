using Project.DAL.Abstract;
using Project.DAL.Concrete;
using Project.DAL.Repository;
using Project.ENTITIES.Concrete;

namespace Project.DAL.EF
{
    public class EFSubAboutDal : GenericRepository<SubAbout>, ISubAboutDal
    {
        public EFSubAboutDal(Context db) : base(db)
        {

        }
    }
}
