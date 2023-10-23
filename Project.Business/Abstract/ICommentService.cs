using Project.ENTITIES.Concrete;
using System.Collections.Generic;

namespace Project.Business.Abstract
{
    public interface ICommentService : IGenericService<Comment>
    {
        List<Comment> TGetDestinationByID(int id);
        List<Comment> TGetCommentsWithDestinations();

    }
}
