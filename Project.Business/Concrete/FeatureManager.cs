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
  public  class FeatureManager :IFeatureService
    {
        IFeatureDal _featuresDal;

        public FeatureManager(IFeatureDal featuresDal)
        {
            _featuresDal = featuresDal;
        }

        public void TAdd(Features t)
        {
            _featuresDal.Add(t);
        }

        public bool TAny(Expression<Func<Features, bool>> exp)
        {
            return _featuresDal.Any(exp);

        }

        public void TDelete(Features t)
        {
            _featuresDal.Delete(t);

        }

        public void TDestroy(Features t)
        {
            _featuresDal.Destroy(t);

        }

        public Features TFind(int id)
        {
            return _featuresDal.Find(id);
        }

        public Features TFirstOrDefault(Expression<Func<Features, bool>> exp)
        {
            return _featuresDal.FirstOrDefault(exp);

        }

        public List<Features> TGetActives()
        {
            return _featuresDal.GetActives();

        }

        public List<Features> TGetFirstDatas(int number)
        {
            return _featuresDal.GetFirstDatas(number);

        }

        public List<Features> TGetLastDatas(int number)
        {
                      return _featuresDal.GetLastDatas(number);

        }

        public List<Features> TGetList()
        {
            return _featuresDal.GetAll();
        }

        public List<Features> TGetPasives()
        {
            return _featuresDal.GetPassives();

        }

        public List<Features> TGetUpdatedes()
        {
            return _featuresDal.GetUpdateds();

        }

        public IQueryable<X> TSelect<X>(Expression<Func<Features, X>> exp)
        {
            return _featuresDal.Select(exp);

        }

        public void TUpdate(Features t)
        {
            _featuresDal.Update(t);

        }

        public List<Features> TWhere(Expression<Func<Features, bool>> exp)
        {
            return _featuresDal.Where(exp);
        }
    }
}
