using Project.DAL.Abstract;
using Project.DAL.Context;
using Project.DAL.Repository;
using Project.ENTITIES.Concrete;

namespace Project.DAL.EF
{
    public class EFAbout2Dal : GenericRepository<About2>, IAbout2Dal
    {
        public EFAbout2Dal(MyContext db) : base(db)
        {

        }
    }
}
