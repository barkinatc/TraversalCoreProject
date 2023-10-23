using Project.DAL.Abstract;
using Project.DAL.Concrete;
using Project.DAL.Repository;
using Project.ENTITIES.Concrete;

namespace Project.DAL.EF
{
    public class EFContactDal : GenericRepository<Contact>, IContactDal
    {
        public EFContactDal(Context db) : base(db)
        {

        }
    }
}
