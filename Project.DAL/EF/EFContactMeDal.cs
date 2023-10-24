using Project.DAL.Abstract;
using Project.DAL.Context;
using Project.DAL.Repository;
using Project.ENTITIES.Concrete;

namespace Project.DAL.EF
{
    public class EFContactMeDal : GenericRepository<ContactMe>, IContactMeDal
    {
        public EFContactMeDal(MyContext db) : base(db)
        {

        }
    }
}
