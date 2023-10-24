using Microsoft.EntityFrameworkCore;
using Project.DAL.Abstract;
using Project.DAL.Context;
using Project.DAL.Repository;
using Project.ENTITIES.Concrete;
using System.Collections.Generic;
using System.Linq;

namespace Project.DAL.EF
{
    public class EFCommentDal : GenericRepository<Comment>, ICommentDal
    {
        public EFCommentDal(MyContext db) : base(db)
        {

        }
        public List<Comment> GetCommentsWithDestinations()
        {
            using (var context = new MyContext())
            {
                return context.Comments.Include(x => x.AppUser).Include(x => x.Destination).Where(x => x.Status != ENTITIES.Enums.DataStatus.Deleted).ToList();
            }

        }
    }
}
