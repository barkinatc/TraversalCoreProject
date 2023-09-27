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
    public class About2Manager:IAbout2Service
    {
        IAbout2Dal _about2Dal;

        public About2Manager(IAbout2Dal about2Dal)
        {
            _about2Dal = about2Dal;
        }

        public void TAdd(About2 t)
        {
            _about2Dal.Add(t);
        }

        public bool TAny(Expression<Func<About2, bool>> exp)
        {
            return _about2Dal.Any(exp);
        }

        public void TDelete(About2 t)
        {
            _about2Dal.Delete(t);
        }

        public void TDestroy(About2 t)
        {
            _about2Dal.Destroy(t);

        }

        public About2 TFind(int id)
        {
            return _about2Dal.Find(id);
        }

        public About2 TFirstOrDefault(Expression<Func<About2, bool>> exp)
        {
            return _about2Dal.FirstOrDefault(exp);
        }

        public List<About2> TGetActives()
        {
            return _about2Dal.GetActives();
        }

        public List<About2> TGetFirstDatas(int number)
        {
          return  _about2Dal.GetFirstDatas(number);
        }

        public List<About2> TGetLastDatas(int number)
        {
            return _about2Dal.GetLastDatas(number);

        }

        public List<About2> TGetList()
        {
            return _about2Dal.GetAll();
        }

        public List<About2> TGetPasives()
        {
            return _about2Dal.GetPassives();
        }

        public List<About2> TGetUpdatedes()
        {
            return _about2Dal.GetUpdateds();
        }

        public IQueryable<X> TSelect<X>(Expression<Func<About2, X>> exp)
        {
            return _about2Dal.Select(exp);
        }

        public void TUpdate(About2 t)
        {
            _about2Dal.Update(t);
        }

        public List<About2> TWhere(Expression<Func<About2, bool>> exp)
        {
            return _about2Dal.Where(exp);
        }
    }
}
