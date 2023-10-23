using Project.DAL.Abstract;
using Project.DAL.Concrete;
using Project.DAL.Repository;
using Project.ENTITIES.Concrete;

namespace Project.DAL.EF
{
    public class EFNewsletterDal : GenericRepository<Newsletter>, INewsletterDal
    {
        public EFNewsletterDal(Context db) : base(db)
        {

        }
    }
}
