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
   public class SideFeatureManager:ISideFeatureService
    {
        ISideFeatureDal _sideFeatureDal;

        public SideFeatureManager(ISideFeatureDal sideFeatureDal)
        {
            _sideFeatureDal = sideFeatureDal;
        }

        public void TAdd(SideFeatures t)
        {
            _sideFeatureDal.Add(t);
        }

        public bool TAny(Expression<Func<SideFeatures, bool>> exp)
        {
            return _sideFeatureDal.Any(exp);

        }

        public void TDelete(SideFeatures t)
        {
            _sideFeatureDal.Delete(t);

        }

        public void TDestroy(SideFeatures t)
        {
                        _sideFeatureDal.Destroy(t);

        }

        public SideFeatures TFind(int id)
        {
            return _sideFeatureDal.Find(id);

        }

        public SideFeatures TFirstOrDefault(Expression<Func<SideFeatures, bool>> exp)
        {
            return _sideFeatureDal.FirstOrDefault(exp);

        }

        public List<SideFeatures> TGetActives()
        {
            return _sideFeatureDal.GetActives();

        }

        public List<SideFeatures> TGetFirstDatas(int number)
        {
            return _sideFeatureDal.GetFirstDatas(number);

        }

        public List<SideFeatures> TGetLastDatas(int number)
        {
            return _sideFeatureDal.GetLastDatas(number);

        }

        public List<SideFeatures> TGetList()
        {
            return _sideFeatureDal.GetAll();

        }

        public List<SideFeatures> TGetPasives()
        {
            return _sideFeatureDal.GetPassives();

        }

        public List<SideFeatures> TGetUpdatedes()
        {
            return _sideFeatureDal.GetUpdateds();

        }

        public IQueryable<X> TSelect<X>(Expression<Func<SideFeatures, X>> exp)
        {
            return _sideFeatureDal.Select(exp);

        }

        public void TUpdate(SideFeatures t)
        {
            _sideFeatureDal.Update(t);

        }

        public List<SideFeatures> TWhere(Expression<Func<SideFeatures, bool>> exp)
        {

            return _sideFeatureDal.Where(exp);
        }
    }
}
