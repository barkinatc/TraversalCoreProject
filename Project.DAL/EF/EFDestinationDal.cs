using Project.DAL.Abstract;
using Project.DAL.Concrete;
using Project.DAL.Repository;
using Project.ENTITIES.Concrete;

namespace Project.DAL.EF
{
    public class EFDestinationDal : GenericRepository<Destination>, IDestinationDal
    {

        public EFDestinationDal(Context db) : base(db)
        {

        }
    }
}
