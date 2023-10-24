using Project.DAL.Abstract;
using Project.DAL.Context;
using Project.DAL.Repository;
using Project.ENTITIES.Concrete;

namespace Project.DAL.EF
{
    public class EFNewsletterDal : GenericRepository<Newsletter>, INewsletterDal
    {
        public EFNewsletterDal(MyContext db) : base(db)
        {

        }
    }
}
