using Project.DAL.Abstract;
using Project.DAL.Context;
using Project.DAL.Repository;
using Project.ENTITIES.Concrete;

namespace Project.DAL.EF
{
    public class EFSubAboutDal : GenericRepository<SubAbout>, ISubAboutDal
    {
        public EFSubAboutDal(MyContext db) : base(db)
        {

        }
    }
}
