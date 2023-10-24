using Project.DAL.Abstract;
using Project.DAL.Context;
using Project.DAL.Repository;
using Project.ENTITIES.Concrete;

namespace Project.DAL.EF
{
    public class EFDestinationDal : GenericRepository<Destination>, IDestinationDal
    {

        public EFDestinationDal(MyContext db) : base(db)
        {

        }
    }
}
