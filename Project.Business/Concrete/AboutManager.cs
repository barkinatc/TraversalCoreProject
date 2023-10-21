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
    public class AboutManager : IAboutService
    {
        IAboutDal _aboutDal;
        public AboutManager(IAboutDal aboutDal)
        {
            _aboutDal = aboutDal;
        }
        public void TAdd(About t)
        {
            _aboutDal.Add(t);
        }

        public bool TAny(Expression<Func<About, bool>> exp)
        {
           return _aboutDal.Any(exp);
        }

        public void TDelete(About t)
        {
            _aboutDal.Delete(t);
        }

        public void TDestroy(About t)
        {
            _aboutDal.Destroy(t);
        }

        public About TFind(int id)
        {
            return _aboutDal.Find(id);
        }

        public About TFirstOrDefault(Expression<Func<About, bool>> exp)
        {
            return _aboutDal.FirstOrDefault(exp);
        }

        public List<About> TGetActives()
        {
            return _aboutDal.GetActives();
        }

        public IQueryable<About> TGetAllAsQueryable()
        {
            throw new NotImplementedException();
        }

        public List<About> TGetFirstDatas(int number)
        {
           return _aboutDal.GetFirstDatas(number);
        }

        public List<About> TGetLastDatas(int number)
        {
            return _aboutDal.GetLastDatas(number);
        }

        public List<About> TGetList()
        {
            return _aboutDal.GetAll();
        }

        public List<About> TGetPasives()
        {
            return _aboutDal.GetPassives();
        }

        public List<About> TGetUpdatedes()
        {
          return  _aboutDal.GetUpdateds();
        }

        public IQueryable<About> TInclude(Expression<Func<About, object>> includeProperty)
        {
            return _aboutDal.Include(includeProperty);
        }

        public IQueryable<X> TSelect<X>(Expression<Func<About, X>> exp)
        {
            return _aboutDal.Select(exp);
        }

        public void TUpdate(About t)
        {
            _aboutDal.Update(t);
        }

        public List<About> TWhere(Expression<Func<About, bool>> exp)
        {
            return _aboutDal.Where(exp);
        }
    }
}
