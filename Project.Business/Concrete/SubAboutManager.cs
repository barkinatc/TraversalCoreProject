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
   public class SubAboutManager:ISubAboutService
    {
        ISubAboutDal _subAboutDal;

        public SubAboutManager(ISubAboutDal subAboutDal)
        {
            _subAboutDal = subAboutDal;
        }

        public void TAdd(SubAbout t)
        {
            _subAboutDal.Add(t);
        }

        public bool TAny(Expression<Func<SubAbout, bool>> exp)
        {
            return _subAboutDal.Any(exp);

        }

        public void TDelete(SubAbout t)
        {
            _subAboutDal.Delete(t);

        }

        public void TDestroy(SubAbout t)
        {
            _subAboutDal.Destroy(t);

        }

        public SubAbout TFind(int id)
        {
            return _subAboutDal.Find(id);

        }

        public SubAbout TFirstOrDefault(Expression<Func<SubAbout, bool>> exp)
        {
            return _subAboutDal.FirstOrDefault(exp);

        }

        public List<SubAbout> TGetActives()
        {
            return _subAboutDal.GetActives();

        }

        public List<SubAbout> TGetFirstDatas(int number)
        {
            return _subAboutDal.GetFirstDatas(number);

        }

        public List<SubAbout> TGetLastDatas(int number)
        {
            return _subAboutDal.GetLastDatas(number);

        }

        public List<SubAbout> TGetList()
        {
            return _subAboutDal.GetAll();

        }

        public List<SubAbout> TGetPasives()
        {
            return _subAboutDal.GetPassives();

        }

        public List<SubAbout> TGetUpdatedes()
        {
            return _subAboutDal.GetUpdateds();

        }

        public IQueryable<SubAbout> TInclude(Expression<Func<SubAbout, object>> includeProperty)
        {
            return _subAboutDal.Include(includeProperty);
        }

        public IQueryable<X> TSelect<X>(Expression<Func<SubAbout, X>> exp)
        {
            return _subAboutDal.Select(exp);

        }

        public void TUpdate(SubAbout t)
        {
            _subAboutDal.Update(t);

        }

        public List<SubAbout> TWhere(Expression<Func<SubAbout, bool>> exp)
        {
            return _subAboutDal.Where(exp);
        }
    }
}
