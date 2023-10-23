using Project.Business.Abstract;
using Project.DAL.Abstract;
using Project.ENTITIES.Concrete;
using System.Collections.Generic;

namespace Project.Business.Concrete
{
    public class CommentManager : BaseManager<Comment>, ICommentService
    {

        ICommentDal _commentDal;
        public CommentManager(ICommentDal commentDal) : base(commentDal)
        {
            _commentDal = commentDal;
        }


        public List<Comment> TGetDestinationByID(int id)

        {
            return _commentDal.Where(x => x.DestinationID == id);
        }



        public List<Comment> TGetCommentsWithDestinations()
        {
            return _commentDal.GetCommentsWithDestinations();
        }


    }
}
