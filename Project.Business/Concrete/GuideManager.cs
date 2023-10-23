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
  public  class GuideManager:IGuideService
    {

        IGuideDal _guideDal;

        public GuideManager(IGuideDal guideDal)
        {
            _guideDal = guideDal;
        }

        public void TAdd(Guide t)
        {
            _guideDal.Add(t);
        }

        public bool TAny(Expression<Func<Guide, bool>> exp)
        {
            return _guideDal.Any(exp);

        }

        public void TDelete(Guide t)
        {
            _guideDal.Delete(t);

        }

        public void TDestroy(Guide t)
        {
            _guideDal.Destroy(t);

        }

        public Guide TFind(int id)
        {
            return _guideDal.Find(id);
        }

        public Guide TFirstOrDefault(Expression<Func<Guide, bool>> exp)
        {
            return _guideDal.FirstOrDefault(exp);

        }

        public List<Guide> TGetActives()
        {
            return _guideDal.GetActives();
        }

      

        public List<Guide> TGetFirstDatas(int number)
        {
            return _guideDal.GetFirstDatas(number);

        }

        public List<Guide> TGetLastDatas(int number)
        {
            return _guideDal.GetLastDatas(number);

        }

        public List<Guide> TGetList()
        {
                        return _guideDal.GetAll();

        }

        public List<Guide> TGetPasives()
        {
            return _guideDal.GetPassives();

        }

        public List<Guide> TGetUpdatedes()
        {
            return _guideDal.GetUpdateds();

        }

        public IQueryable<Guide> TInclude(Expression<Func<Guide, object>> includeProperty)
        {
            return _guideDal.Include(includeProperty);
        }

        public IQueryable<X> TSelect<X>(Expression<Func<Guide, X>> exp)
        {
            return _guideDal.Select(exp);

        }

        public void TUpdate(Guide t)
        {
            _guideDal.Update(t);

        }

        public List<Guide> TWhere(Expression<Func<Guide, bool>> exp)
        {
            return _guideDal.Where(exp);
        }
    }
}
