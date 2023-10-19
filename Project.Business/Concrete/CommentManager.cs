using Project.Business.Abstract;
using Project.DAL.Abstract;
using Project.ENTITIES.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Project.Business.Concrete
{
    public class CommentManager : ICommentService
    {

        ICommentDal _commentDal;
        public CommentManager(ICommentDal commentDal)
        {
            _commentDal = commentDal;
        }
        public void TAdd(Comment t)
        {
            _commentDal.Add(t);
        }

        public bool TAny(Expression<Func<Comment, bool>> exp)
        {
            return _commentDal.Any(exp);
        }

        public void TDelete(Comment t)
        {
            _commentDal.Delete(t);
        }

        public void TDestroy(Comment t)
        {
            _commentDal.Destroy(t);
        }

        public Comment TFind(int id)
        {
            return _commentDal.Find(id);
        }

        public Comment TFirstOrDefault(Expression<Func<Comment, bool>> exp)
        {
            return _commentDal.FirstOrDefault(exp);
        }

        public List<Comment> TGetActives()
        {
            return _commentDal.GetActives();
        }

        public List<Comment> TGetFirstDatas(int number)
        {
            return _commentDal.GetFirstDatas(number);
        }

        public List<Comment> TGetLastDatas(int number)
        {
            return _commentDal.GetLastDatas(number);

        }

        public List<Comment> TGetList()
        {
            return _commentDal.GetAll();

        }

        public List<Comment> TGetPasives()
        {
            return _commentDal.GetPassives();

        }

        public List<Comment> TGetUpdatedes()
        {
            return _commentDal.GetUpdateds();

        }

        public IQueryable<X> TSelect<X>(Expression<Func<Comment, X>> exp)
        {
            return _commentDal.Select(exp);

        }

        public void TUpdate(Comment t)
        {
             _commentDal.Update(t);

        }

        public List<Comment> TWhere(Expression<Func<Comment, bool>> exp)
        {
            return _commentDal.Where(exp);

        }

        public List<Comment> TGetDestinationByID(int id)

        {
            return _commentDal.Where(x => x.DestinationID == id);
        }

        public IQueryable<Comment> TInclude(Expression<Func<Comment, object>> includeProperty)
        {
            return _commentDal.Include(includeProperty);
            
        }

        public List<Comment> TGetCommentsWithDestinations()
        {
            return _commentDal.GetCommentsWithDestinations();
        }
    }
}
