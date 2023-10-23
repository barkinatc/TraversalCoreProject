using Microsoft.EntityFrameworkCore;
using Project.DAL.Abstract;
using Project.DAL.Concrete;
using Project.DAL.Repository;
using Project.ENTITIES.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.DAL.EF
{
   public class EFCommentDal : GenericRepository<Comment>, ICommentDal
    {
        public List<Comment> GetCommentsWithDestinations()
        {
            using (var context = new Context())
            {
                return context.Comments.Include(x=>x.AppUser).Include(x => x.Destination).Where(x => x.Status != ENTITIES.Enums.DataStatus.Deleted).ToList();
            }

        }
    }
}
