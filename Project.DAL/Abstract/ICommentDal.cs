using Project.ENTITIES.Concrete;
using System.Collections.Generic;

namespace Project.DAL.Abstract
{
    public interface ICommentDal : IGenericDal<Comment>
    {
        List<Comment> GetCommentsWithDestinations();
    }
}
